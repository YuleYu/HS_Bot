# HS_Bot

炉石传说的脚本机器人基于 C# 实现。(看到天梯上海盗战这么多挂机还能上低保忍不住自己也想写一个)
写起来发现策略这种东西机器和人还是很有差距的……(对于 ML ，两手一摊，我也很无奈)
而且有个很重要的问题就是，不知道那些外挂脚本是通过什么方式 hook 进炉石的……现在找到的是德国的一个 Hearthbuddy 外挂，但要付费（价格还不低）。在想反编译的方式能不能有点进展。

现在写的有点慢，并且主要目的有两个：
1. 如何让 strategy 更完善。
   先不去说是强策略性还是弱策略性，变量因素要考虑哪些。有时候脚本会作出一些很费解的操作，光是解决这种小问题就得找好久。
2. 如何让 behavior 看起来更像正常人。
   比如操作时犹豫不决，法术指向的更换。在现实对战中发送表情，如果是脚本基本不会回应。

目前这个脚本还没有完工，缺少所有牌的信息(感觉这又是一项大工程)。另外怕是等完善了新版本又出了不同机制产生 bug：毕竟在这里连抉择都是写死的，万一出了什么多重抉择……

唔，心心念念着，感觉还是 ML 实现靠谱(可惜我已经走太远了？)
