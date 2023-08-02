# You can pick any Debian/Ubuntu-based image. 😊
FROM mcr.microsoft.com/devcontainers/base:bullseye

LABEL maintainer="a.lorite.mora@gmail.com"

# Options for setup script
ARG INSTALL_ZSH="true"
ARG UPGRADE_PACKAGES="true"
ARG USERNAME=lorite
ARG USER_UID=1001
ARG USER_GID=$USER_UID
# Install needed packages and setup non-root user. Use a separate RUN statement to add your own dependencies.
COPY library-scripts/*.sh /tmp/library-scripts/
RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
    && /bin/bash /tmp/library-scripts/common-debian.sh "${INSTALL_ZSH}" "${USERNAME}" "${USER_UID}" "${USER_GID}" "${UPGRADE_PACKAGES}" "true" "true" \
    && apt-get install -y pkg-config zip g++ zlib1g-dev unzip python \
    && apt-get autoremove -y && apt-get clean -y && rm -rf /var/lib/apt/lists/* /tmp/library-scripts \
    && locale-gen en_US.UTF-8

# generate locale for agnoster
RUN echo "en_US.UTF-8 UTF-8" > /etc/locale.gen && /usr/sbin/locale-gen

# Install Bazel
ARG BAZELISK_VERSION=v1.10.1
ARG BAZELISK_DOWNLOAD_SHA=dev-mode
RUN curl -fSsL -o /usr/local/bin/bazelisk https://github.com/bazelbuild/bazelisk/releases/download/${BAZELISK_VERSION}/bazelisk-linux-amd64 \
    && ([ "${BAZELISK_DOWNLOAD_SHA}" = "dev-mode" ] || echo "${BAZELISK_DOWNLOAD_SHA} */usr/local/bin/bazelisk" | sha256sum --check - ) \
    && chmod 0755 /usr/local/bin/bazelisk
RUN sudo mv $(which bazelisk) /usr/local/bin/bazel
RUN bazel

# Install pip
RUN apt-get update \
    && apt-get -y install python3-pip
RUN pip install --upgrade pip

# Install go
RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
    && apt-get -y install --no-install-recommends golang-go 

# Install fontconfig
RUN apt-get update \
    && apt-get -y install fontconfig

# Install powerline fonts
RUN sudo apt-get update && export DEBIAN_FRONTEND=noninteractive \
    && apt-get -y install --no-install-recommends fonts-powerline

# Change username to avoid permission issues
USER ${USERNAME}
ENV HOME /home/${USERNAME}

ENV TERM xterm

# Set the default shell to bash rather than sh
ENV SHELL /bin/zsh

# Install bazel buildifier (from go)
RUN go get -u github.com/bazelbuild/buildtools/buildifier
ENV PATH=$PATH:/home/${USERNAME}/go/bin

 # run the installation script  
RUN wget https://github.com/robbyrussell/oh-my-zsh/raw/master/tools/install.sh -O - | zsh || true

# install powerlevel10k
# install required fonts
RUN cd $HOME && git clone https://github.com/lxbrtsch/Menlo-for-Powerline.git \
    && mkdir -p ~/.local/share/fonts && cp Menlo-for-Powerline/*.ttf ~/.local/share/fonts/ && fc-cache -f -v
# install powerlevel10k
RUN git clone https://github.com/romkatv/powerlevel10k.git ~/.oh-my-zsh/custom/themes/powerlevel10k
# install zsh plugins
RUN git clone https://github.com/zsh-users/zsh-autosuggestions.git ~/.oh-my-zsh/custom/plugins/zsh-autosuggestions 
RUN git clone https://github.com/zsh-users/zsh-syntax-highlighting.git ~/.oh-my-zsh/custom/plugins/zsh-syntax-highlighting

RUN cd $HOME && curl -fsSLO https://raw.githubusercontent.com/romkatv/dotfiles-public/master/.purepower

# zsh configuration
ADD lorite-scripts/.zshrc $HOME/
ADD lorite-scripts/.p10k.zsh $HOME/
