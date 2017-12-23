# PMDFileWatcher
PMDMML監視ツール  
Copyright (C) 2017 Rerrah

## 概要
PMDFileWatcherはPMD用MMLの更新を監視し、自動でMMLコンパイラを実行してFMPMDなどのプレーヤに再生させるソフトです。  
コンパイル・再生時に利用するプログラムは「Settings」で指定できます。  
  
64bit Windows OS上では16bitプログラムであるMCを直接実行することができません。MMLのコンパイルを行うには[MS-DOS Player](http://takeda-toshiya.my.coocan.jp/msdos/)が必要となります。

### MMLのコンパイル
MMLをドラッグ&ドロップして監視対象とすることができます。  
Startボタンを押すことで指定したMMLの監視を開始します。  
MMLが更新されたとき、「Settings」で指定されたMS-DOS Player(任意)とMCを自動実行しMMLをコンパイルします。  
コンパイル終了後、コンパイル結果フォームが開きます。  
なお、コンパイル後のデータ(拡張子が.M、.M2などのファイル)は監視するMMLと同じフォルダに生成されます。  
Stopボタンを押すとMMLの監視を停止します。  
また、「Compile」でMMLの強制コンパイルを行うことができます。

### 自動再生
コンパイル後にデータを自動再生を行うかの選択は「Settings」で指定できます。  
自動再生を行う場合、「Settings」の「Autoplay」で実行するソフトを指定してください。

## 対応環境
* Windows OS (Windows8,10で確認済み)
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
