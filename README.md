# PMDFileWatcher
PMDMML監視ツール  
Copyright (C) 2017 Rerrah

## 概要
PMDFileWatcherはPMD用MMLの更新を監視し、自動でMMLコンパイラを実行してFMPMDなどのプレーヤに再生させるソフトです。  
コンパイル・再生時に利用するプログラムは環境設定で指定できます。  
  
64bit Windows OS上では16bitプログラムであるMCを直接実行することができません。そのためこのソフトでコンパイルするためには[MS-DOS Player](http://takeda-toshiya.my.coocan.jp/msdos/)が必要となります。

### MMLのコンパイル
監視開始ボタンを押すことで指定したMMLの監視を始めます。  
MMLが更新されたとき、環境設定で指定されたMS-DOS Player(任意)とMCを自動実行しMMLをコンパイルします。  
コンパイル終了後、コンパイル結果フォームが開きます。  
なお、コンパイル後のデータ(拡張子が.M、.M2などのファイル)は監視するMMLと同じディレクトリに生成されます。

### 自動再生
コンパイル後にデータを自動再生を行うかの選択は環境設定で指定できます。  
自動再生を行う場合、環境設定で実行するソフトを指定してください。

## 対応環境
* Windows OS (Windows10 64bit版では確認済み)
* .NET Framework 4.6.1以降がインストールされている環境
* MC、MS-DOS Player(任意)、コンパイルデータの再生ソフト(任意)がインストールされている環境

## インストール
ダウンロードした圧縮ファイルをインストールするフォルダに移動させ、解凍してください。

## 使用方法
PMDFileWatcher.exeをダブルクリックしてください。

## アンインストール
インストールしたフォルダを削除してください。

## 著作権 / ライセンス
本ソフトの著作権はRerrahが所有します。  
本ソフトのライセンスはMIT Licenseです。
