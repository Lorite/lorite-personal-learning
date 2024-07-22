import requests
from bs4 import BeautifulSoup
from PIL import Image
from io import BytesIO
import os

class MiroTemplate:
  name = ""
  description = ""
  image = ""

  def __str__(self):
    return f"Name: {self.name}\nDescription: {self.description}\nImage: {self.image}\n"

def get_miro_templates(url: str) -> list[MiroTemplate]:
  response = requests.get(url)
  response.encoding = response.apparent_encoding
  if response.status_code == 200:
    soup = BeautifulSoup(response.text, 'html.parser')
    template_elements = soup.find_all('div', class_='Box-sc-g760pt-0 TemplateCard__ImageContainer-sc-jfbzgc-0 nKFPx') or []
    miro_templates = []
    for element in template_elements:
      temp_miro_template = MiroTemplate()
      for img in element.find_all('img', src=True) or []:
        temp_miro_template.image = img['src']
      for title in element.find_all('h4', class_='Text-sc-wsqynr-0 esbiYB') or []:
        temp_miro_template.name = title.text
      for description in element.find_all('p', class_='Text-sc-wsqynr-0 cYtfIz') or []:
        temp_miro_template.description = description.text
      miro_templates.append(temp_miro_template)
    return miro_templates
  else:
    print("Failed to retrieve the webpage")
    return []

def save_miro_templates(templates: list[MiroTemplate], file_path: str):
  images_path = file_path.replace(".txt", "") + "/images"
  with open(file_path, 'w') as file:
    os.makedirs(images_path)
    for template in templates:
      # save title and description to a file
      file.write(f"## {template.name}\n")
      file.write(f"{template.description}\n")
      file.write(f"![{template.name}]({images_path}/{template.name}.png)\n")
      file.write("\n")
      # save image to folder
      response = requests.get(template.image)
      img = Image.open(BytesIO(response.content))
      image = img.save(f"{images_path}/{template.name}.png")

def main():
  miro_templates = get_miro_templates("https://miro.com/templates/agile/")
  for miro_template in miro_templates:
    print(miro_template)
  save_miro_templates(miro_templates, file_path.replace(".txt", "") + "/miro_templates.txt")

if __name__ == "__main__":
  main()
