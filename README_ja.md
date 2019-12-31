# PMDFileWatcher
PMDMML監視ツール  
Copyright (C) 2017-2019 Rerrah

[![GitHub release](https://img.shields.io/badge/release-v1.3.0-brightgreen.svg)](https://github.com/rerrahkr/PMDFileWatcher/releases)
![Platform: windows](https://img.shields.io/badge/platform-windows-lightgrey.svg)
![.Net Framework: >=4.6](https://img.shields.io/badge/.NET-%3E%3D4.6-blue.svg)
[![LICENSE](https://img.shields.io/github/license/rerrahkr/PMDFileWatcher.svg)](./LICENSE)

[English](./README.md)

## 概要
PMDFileWatcherはPMD用MMLの更新を監視し、自動でMMLコンパイラを実行してFMPMDなどのプレーヤに再生させるソフトです。  
コンパイル・再生に利用するプログラムは「Settings」で指定できます。

#### 64-bit OSでMMLをコンパイルする際の注意点
64bit Windows OSでは16bitプログラムであるMC.EXEを直接実行することができません。  
このアプリは[MS-DOS Player](http://takeda-toshiya.my.coocan.jp/msdos/)を通してMCを実行するため、コンパイルする前に予めMS-DOS Playerを用意する必要があります。  
またSettingsでMS-DOS Playerへのパスを設定する必要があります。

MCを上の実行可能ファイルに予めに変換しておくことで、毎回MS-DOS Playerを使用せずにMCを実行する事も可能です。  
MS-DOS Playerには`-c`オプションがあり、これにより変換されたexeが作成されます。

```bat
./msdos.exe -c"新しいexeのパス" "MCのパス"
```

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
*詳しくは[LICENSE](./LICENSE)を参照してください。*
