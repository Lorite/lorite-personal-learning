# setup input
cat << 'EOF' > ~/.inputrc
"\e[A":history-search-backward
"\e[B":history-search-forward
"\e[1;5C":forward-word
"\e[1;5D":backward-word
"\e[5C":forward-word
"\e[5D":backward-word
"\e\e[C":forward-word
"\e\e[D":backward-word
"\e[1~":beginning-of-line
"\e[4~":end-of-line
"\e[3~":delete-char
"\e[2~":quoted-insert
EOF

bind -f ~/.inputrc

# Custom aliases
alias l='ls -a'
alias ll='ls -l'
alias la='ls -la' 

# add a list of usual commands
commands_array=()
commands_array+=("bazel build ... --config=clang")
commands_array+=("bazel test ... --config=clang --nocache_test_results --test_output=all")
commands_array+=("bazel test ... --color=yes --keep_going --config=remote-clang --runs_per_test=100 --runs_per_test_detects_flakes --test_output=errors --nocache_test_results")
commands_array+=("git checkout develop")
commands_array+=("git checkout -b develop_REDSW-000_allm_my-task")
commands_array+=("git log --oneline -n 10")
commands_array+=("git rebase -i HEAD~2 --autostash")
commands_array+=("git rebase origin/develop --autostash")
commands_array+=("bazel coverage ... --config=coverage-lcov --config=clang")
commands_array+=("ssh user@ip")

# delete the usual commands and write them again so that they are at the end of the file and not dupe
for i in "${commands_array[@]}"
do
    # grep -v "$i" ~/.bash_history > tmpfile && mv tmpfile ~/.bash_history # remove command
    echo "$i" >> ~/.bash_history # add command
done
