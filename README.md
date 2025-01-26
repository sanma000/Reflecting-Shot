# Unity-Homework

チュートリアル

### git push までの流れ

1. mainブランチを最新にする
    ```
    git pull
    ```
    1. developブランチを作成し、リモートに反映する
        ```
        git switch -c develop
        git push -u origin develop
        ```
        1. developブランチを最新にする
            ```
            git pull
            ```
        2. featureブランチを作成し、リモートに反映する
            ```
            git switch -c feature
            git push -u origin feature
            ```
        2. 編集を行う
        3. (developブランチの最新状態を確認する)
            ```
            git switch -
            git pull
            ```
        3. リモートに変更をpushする
            ```
            git add ./
            git commit -m ''
            git push
            ```
