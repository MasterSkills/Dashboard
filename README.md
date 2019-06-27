# Simple Dashboard（一个简单的仪表盘）

为什么说简单呢，其实这个Dashboard并没有用到什么太高深的技术，核心是在计算上，一个核心的坐标点计算公式之前已经在我的博客有过分享了：“ [已知圆心和半径手绘一个圆形-C#/WF](https://blog.lost520.cn/2019/05/25/Dotnet/%E5%B7%B2%E7%9F%A5%E5%9C%86%E5%BF%83%E5%92%8C%E5%8D%8A%E5%BE%84%E6%89%8B%E7%BB%98%E4%B8%80%E4%B8%AA%E5%9C%86%E5%BD%A2-C-WF/#more)”，直接套用即可。

以下图片较多，国内网速有点慢，耐心等待下(*Φ皿Φ*)。无法加载请访问：[Dashboard-仪表盘](https://blog.lost520.cn/2019/06/27/Dotnet/%E5%BC%80%E6%BA%90%E4%BB%AA%E8%A1%A8%E7%9B%98-Dashboard-C-WF/#more)

# Dashboard（仪表盘）

**显示效果还是不错的，样式是参考了PowerBI的一个案例。其中所有的颜色都是可以自由搭配替换的。**

![](https://imgservice.lost520.cn/InternetImgService/2019-06-27/20190627141751452.gif)

# Customized Property（自定义属性）

## Expected（期望值）

**标识仪表盘的上限值。**
![](https://imgservice.lost520.cn/InternetImgService/2019-06-27/20190627142535359.png)


## Real（已达到的值/进度值）

![](https://imgservice.lost520.cn/InternetImgService/2019-06-27/20190627142641827.png)

## BottomTitleColor（底部标题颜色）

**指最底部的文字字体颜色。**

![](https://imgservice.lost520.cn/InternetImgService/2019-06-27/20190627142306298.png)

## BottomTitleFont（底部标题字体）

**指最底部的文字的字体。**

## Indicator（指针角度）

**这个说的并非指针真实的角度，但是却和指针的大小关联，值越大标识指针越大，最大不可超过200.**

![](https://imgservice.lost520.cn/InternetImgService/2019-06-27/20190627142928112.png)

## IndicatorColor（指针颜色）

**这个属性指的是指针的颜色。**
## IndicatorFill（填充式指针）

**标识指针是单线条还是填充式的，默认是填充的，也就是如上所展示的，设置False为单线条样式，如下展示。**

![](https://imgservice.lost520.cn/InternetImgService/2019-06-27/20190627143150774.png)

## InnerBackground（内圆弧填充色）

**指的是内测的圆弧背景色，非中心圆。**

![](https://imgservice.lost520.cn/InternetImgService/2019-06-27/20190627143347992.png)

## OuterColor（外圆线条颜色）

**指的是如图所指的外侧的浅蓝色线条的颜色。**

![](https://imgservice.lost520.cn/InternetImgService/2019-06-27/20190627143923923.png)

## InnerColor（内圆线条颜色）

**指的是如图所指的内侧的深蓝色线条的颜色。**

![](https://imgservice.lost520.cn/InternetImgService/2019-06-27/20190627143533118.png)


## InnerRoundColor（中心圆的填充色）

**指的是中心圆的背景色**

![](https://imgservice.lost520.cn/InternetImgService/2019-06-27/20190627143751613.png)

## ProgressColor（进度条颜色）

**指的是当前进度条划过的颜色**

![](https://imgservice.lost520.cn/InternetImgService/2019-06-27/20190627144100959.png)

## ProgressDisplayModel（进度条显示模式）

**默认模式是Inner模式，有三种可供选择，分别是：Inner、Center、Fill。以下分别展示了三种模式：**

**Inner：**

![](https://imgservice.lost520.cn/InternetImgService/2019-06-27/20190627144318636.png)

**Center：**

![](https://imgservice.lost520.cn/InternetImgService/2019-06-27/20190627144332197.png)

**Fill：**

![](https://imgservice.lost520.cn/InternetImgService/2019-06-27/20190627144343497.png)

## ScaleExpectedColor（期望值的刻度颜色）

**如图中所指，标识没有达到时刻度值和刻度线的颜色。**

![](https://imgservice.lost520.cn/InternetImgService/2019-06-27/20190627144809379.png)


# Override Property（重写的属性）

除了以上重写的属性之外，还使用了从Control继承过来的一些属性。

## Text（文本）

仪表盘中间的Title内容。

## ForeColor（文本颜色）

仪表盘中间的Title颜色。

## Font（文本样式）

仪表盘中间的Title字体。

# 最后
总的来说自定义性还是比较高的，可以自由搭配颜色，界面效果参考自PowerBI，其他内容为原创，转发请注明来源！
