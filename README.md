# PMDFileWatcher
PMDMML監視ツール<br>
Copyright (C) 2017 R.K.R.

## 概要
PMDFileWatcherはPMD用MMLの更新を監視し、自動でMMLコンパイラを実行してFMPMDなどのプレーヤに再生させるソフトです。<br>
コンパイル・再生時に利用するプログラムは環境設定で指定できます。<br>
<br>
このソフトは64bit Windows上でコンパイルを行うことを想定しています。そのためコンパイル時にはPMD付属のMCと[MS-DOS Player](http://takeda-toshiya.my.coocan.jp/msdos/)が必要です。

### MMLのコンパイル
監視開始ボタンを押すことで指定したMMLの監視を始めます。<br>
MMLが更新されたとき、環境設定で指定されたMS-DOS PlayerとMCを自動実行しMMLをコンパイルします。<br>
コンパイル終了後、コンパイル結果フォームが開きます。<br>
なお、コンパイル後のデータ(拡張子が.M、.M2などのファイル)は監視するMMLと同じディレクトリに生成されます。

### 自動再生
コンパイル後にデータを自動再生を行うかの選択は環境設定で指定できます。<br>
自動再生を行う場合、環境設定で実行するソフトを指定してください。

## 対応環境
* 64bit Windows環境 (Windows10では確認済み)
* .NET Framework 4.6.1以降がインストールされている環境

## インストール
ダウンロードした圧縮ファイルをインストールするフォルダに移動させ、解凍してください。

## 使用方法
PMDFileWatcher.exeをダブルクリックしてください。

## アンインストール
インストールしたフォルダを削除してください。

## 著作権 / ライセンス
本ソフトの著作権はR.K.R.が所有します。<br>本ソフトのライセンスはMIT Licenseです。
