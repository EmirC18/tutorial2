## 1. Git performs a fast-forward merge when the target branch has no new commits since the feature branch was created. In that case Git only moves the branch pointer forward.
A merge commit is created when both branches contain new commits and Git must combine their histories.

## 2. Merge combines branches and preserves the full branching history. Rebase moves commits on top of another branch, creating a cleaner and more linear commit history.

## 3. The conflict happened because the same line in Program.cs was modified in both master and feature-conflict.
The conflict was resolved manually by editing the file, removing the conflict markers (<<<<<<<, =======, >>>>>>>) and keeping a final correct version of the startup message.



