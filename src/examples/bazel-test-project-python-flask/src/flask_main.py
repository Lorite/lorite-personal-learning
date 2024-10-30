from calculator_lib import Calculator
from flask import Flask
from random import randint

app = Flask(__name__)
calculator = Calculator()


@app.route("/")
def randomNumberCalculator():
    randomInt1 = randint(0, 250)
    randomInt2 = randint(0, 250)
    return "{} + {} = {}?".format(
        randomInt1, randomInt2, calculator.add(randomInt1, randomInt2)
    )


if __name__ == "__main__":
    app.run(host="0.0.0.0")
