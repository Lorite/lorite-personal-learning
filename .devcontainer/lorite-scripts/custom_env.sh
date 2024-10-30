# setup input
cat <<'EOF' >~/.inputrc
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

# add a list of usual commands
history_cmds_array=()
history_cmds_array+=("bazel build ... --config=clang")
history_cmds_array+=("bazel test ... --config=clang --nocache_test_results --test_output=all")
history_cmds_array+=("bazel test ... --color=yes --keep_going --config=remote-clang --runs_per_test=100 --runs_per_test_detects_flakes --test_output=errors --nocache_test_results")
history_cmds_array+=("git checkout develop")
history_cmds_array+=("git checkout -b develop_REDSW-000_allm_my-task")
history_cmds_array+=("git log --oneline -n 10")
history_cmds_array+=("git rebase -i HEAD~2 --autostash")
history_cmds_array+=("git rebase origin/develop --autostash")
history_cmds_array+=("bazel coverage .s.. --config=coverage-lcov --config=clang")
history_cmds_array+=("ssh user@ip")
for i in "${history_cmds_array[@]}"; do
	# grep -v "$i" ~/.zsh_history > tmpfile && mv tmpfile ~/.zsh_history # remove command
	echo "$i" >>~/.zsh_history # add command
done
