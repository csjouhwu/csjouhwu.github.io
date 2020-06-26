## csjouhwu.github.io
### SD1082 2020/6/17
## 第1週課程摘記(asp.net core/atom/docker / Console/ Web/UseUrls/Mobile)
### wk0101 CS 基本架構
dotnet new console -o wk0101 <br/>
cd wk0101 <br/>
dotnet run <br/>
![GitHub Logo](/wk0101.png)
### wk0102 CS Web 程式架構
dotnet new web -o wk0102<br/>
cd wk0102 <br/>
dotnet run <br/>
chrome https://localhost:5001/<br/>
![web 1](/Figs/wk0102.png)
### wk0103.html VR 基本架構
https://aframe.io<br/>
### wk0104 Docker Hello world
https://hub.docker.com/_/hello-world <br/>
docker run hello-world<br/>
docker images<br/>
![docker hello](/Figs/wk0104.png)
## 第2週課程摘記(Review Wk1 atom/asp.net core/ aframe.io mobile/ C# I/O)
### wk0201 CS 基礎 (I/O)
namespace xx <br/>
{<br/>
  class oo<br/>
  {<br/>
    static void Main()<br/>
    {<br/>
      ... <br/>
    }<br/>
  }<br/>
}<br/>
![Console1](/Figs/wk0201.png)
## 第3週課程摘記(C# 基礎：for/ if /Winforms)
### wk0302 CS 基礎 (for)
![Console2](Figs/wk0302.png)
### wk0303 CS Form app
dotnet new WinForms -o wk0303<br/>
![Console2](Figs/wk0303.png)
## 第4週課程摘記(C# WinForms/Button/for loop/if)
### wk0401 Form app step by step class/object/for/if
dotnet new WinForms -o wk0401<br/>
button class<br/>
![form1](Figs/wk0402.png)
position<br/>
double loop<br/>
5x5 button<br/>
![form2](Figs/wk0403.png)
## 第5週課程摘記(WPF/for loop/button/helixtoolkit 3D/teapot)
### wk0501B WPF xaml
### wk0501 WPF app step by step class/object/for/if
dotnet new WPF -o wk0501<br/>
button class<br/>
position<br/>
double loop<br/>
5x5 button<br/>
![wpf1](Figs/wk0502.png)
### wk0502 wpf VR external library helixtoolkit.wpf
https://github.com/helix-toolkit/helix-toolkit/wiki/Getting-started-with-WPF-3D
https://www.nuget.org/packages/HelixToolkit.Wpf/
https://docs.microsoft.com/en-us/dotnet/framework/wpf/graphics-multimedia/how-to-apply-multiple-transformations-to-a-3-d-model
![wpf2](Figs/wk0503.png)
## 第6週課程摘記(WPF xaml vs C# / tripple loop)
### wk0601 WPF xaml Transform
### wk0602 WPF xaml vs CS + loop
5x5x5 cube helixtoolkit<br/>
![wpf3](Figs/wk0601.png)
### wk0603 WPF 3D from obj files
![wpf4](Figs/wk0602.png)
## 第7週課程摘記(WPF FileModelVisual3D/DefaultMaterial/xaml vs C#)
### wk0701 WPF 3D DefaultMaterial
![wpf5](Figs/wk0701.png)
### wk0702 WPF 3D DefaultMaterial
### wk0703 WPF 3D xaml vs CS
![wpf6](Figs/wk0702.png)
## 第8週課程摘記(web/html/aframe)
### wk0801 dotnet new web -o wk0801
### wk0802 html basic
### wk0803 aframe basic
## 第9週期中考試摘記(a-obj-model/tag vs javascript)
### wk0901 3d obj tag
### wk0802 3d obj tag vs javascript
## 第10週課程摘記(github account/username.github.io project/skin files of mtl)
### github account
### wk1001 3d mtl files settings
### wk1002 mtl files vs brushes
## 第11週課程摘記(docker/nginx)
### 11-1 docker nginx
https://blog.techbridge.cc/2018/03/17/docker-build-nginx-tutorial/<br/>
cmd<br/>
docker run -d -p 7777:80 --name webserver nginx<br/>
### 11-4 multiple containers
docker --version <br/>
docker run -d -p 7777:80 --name webserver nginx<br/>
docker run -d -p 8888:80 --name webserver2 nginx<br/>
docker ps<br/>
docker cp wk0802.html 3ef:/usr/share/nginx/html/wk0802.html<br/>
docker cp wk0803.html 46f:/usr/share/nginx/html/wk0803.html<br/>
## 第12週課程摘記(Razor C#/loop/staticfiles/asp.net sample container)
### 12-1 Razor
dotnet new razor -o wk1201 <br/>
copy static files into wwwroot<br/>
### 12-2 Razor Container example
docker run -it --rm -p 8000:80 --name aspnetcore_sample mcr.microsoft.com/dotnet/core/samples:aspnetapp<br/>
copy static files into wwwroot<br/>
## 第13週課程摘記(Razor C#/Page 3/marquee)
### 13-1 Razor Page3 架構
## 第14週課程摘記(Razor+aframe/C# string skill/C# vs javascript)
### 14-1 Page4 html
### 14-2 Page5 step by step html + javascript vs CS
## 第15週課程摘記(Razor+aframe/re-write report)
### 15-1 Page6 step by step Razor + aframe
### 15-2 wwwroot
### 15-3 index.html tag vs javascript
## 第16週課程摘記(SPA bootstrap/html a/javascript html-a/drv.tw + qrcode)
### 16-1 goolge driver www.sd1082.io drv.tw
### 16-2 qrcode generator online
### 16-3 upload wwwroot into www.sd1082.io
### 16-4 qrcode scan
## 第17週課程摘記(SPA bootstrap index.html)
### 17-1 img tag src setAttribute
### 17-2 href = id
### drv.tw + qrcode
