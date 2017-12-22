# puzzCode(Puzzle Code)

![螢幕快照 2017-12-21 上午6.21.38.png](resources/02666CA47DBF6E48FF90A7D53556B865.png)

## Description

puzzCode is a simple compiler based on mingw, written in C# to build windows applications in such a way that they can’t be analysed by standard analysis tools (e.g. IDA, Ollydbg, x64dbg, Snowman Decompiler, etc.)

puzzCode is based on MinGW to compile C/C++ source code to assembly language while also obfuscating every instruction. puzzCode transforms each original instruction into obfuscated code by breaking each function into countless pieces.

**The most important thing is that the executable (exe) file, once compiled by puzzCode will be undetectable by antivirus as it effectively will create a completely new application.**

### Example

```
void play(void) {
    int code = rand() % 3;
    switch (code)
    {
      case 0:
        MessageBoxA(0, "hello", "info", 0);
        break;
      case 1:
        MessageBoxA(0, "hola", "info", 0);
        break;
      default:
        MessageBoxA(0, ":/ ...", "info", 0);
        break;
    }
}   
```

### Normal Graph Overview (IDA)

It's pretty easy to understand, right?

![螢幕快照 2017-12-21 上午5.44.18.png](resources/F3D0B8CD285ECAD326C72873AA2D0146.png)


### Graph Overview, Compiled via puzzCode (IDA)

... How about now? :)

![螢幕快照 2017-12-21 上午6.16.17.png](resources/94BA0F1EF7491E9BE5F71BBE80881634.png)

### x64dbg (32bit Mode)

![](resources/snap2017-12-22 下午8.47.53.png)
![](resources/snap2017-12-22 下午8.49.07.png)

### Snowman Plug-in

![](resources/snap2017-12-22 下午8.49.36.png)

## Quick Run

puzzCode only support 32bit Windows PE compiling currently.

1. Install MinGW on your windows environment: https://sourceforge.net/projects/mingw/files/Installer

2. Download from [Release Page](https://github.com/aaaddress1/puzzCode/releases), or clone this project, compile it with Visual C# 2017, you'll get puzzCode software.

## Usage

![螢幕快照 2017-12-21 上午5.36.29.png](resources/454D56B8EF05426D6AE99B82B2F8A166.png)

You have to set the MinGW path on your Windows environment the first time you run puzzCode and enter compiler arguments, linker arguments, and obfuscated degree (from 0 to 100).

![螢幕快照 2017-12-21 上午6.17.08.png](resources/89EFD46DE61B09F2793982E124C535B4.png)
![螢幕快照 2017-12-21 上午6.26.18.png](resources/D6DD734B6E8B5323148B0F707C5053B8.png)

After you setup the configuration, you are able to freely code in puzzCode. Simply hit the "Compile" button and the .exe file will be generated at the same path of your source code file.

### Snippet
![螢幕快照 2017-12-21 上午6.27.23.png](resources/7468CD0110210F9087DEB8A3FE84F929.png)

Some backdoors and programs are really useful but what if you don't have that source code? That's Ok, your can use the `Snippet > RunPE` feature.

![螢幕快照 2017-12-21 上午6.29.06.png](resources/B123B443F08DF005A368FA6FD60B8EC9.png)

puzzCode packs the program you selected, and generates the source code. **Just compile, and get a new undetectable Backdoooooor!!**

*RunPE refer: https://github.com/Zer0Mem0ry/RunPE/blob/master/RunPE.cpp*

