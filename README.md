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
        ```
        ```
        git push -u origin develop
        ```
        リモートにすでにdevelopが存在する場合
        ```
        git branch --set-upstream-to=origin/develop
        ```
        1. developブランチを最新にする
            ```
            git pull
            ```
        2. featureブランチを作成
            ```
            git switch -c feature
            ```
        2. 編集を行う
        3. (developブランチの最新状態を確認する)
            ```
            git switch develop
            ```
            ```
            git pull
            ```
        3. developにmergeする
            ```
            git add ./
            ```
            ```
            git commit -m ''
            ```
            ```
            git switch develop
            ```
            ```
            git merge --no-ff feature
            ```
        5. feature削除
        6. 次のリリースが完成するまで繰り返す
    2. developをリモートへpush
        ```
        git push
        ```
    3. developをmainへpull request, mergeする
    4. リリースする