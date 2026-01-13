public abstract class Zerg
{
    public abstract string Name { get; set; }
    public abstract int MAX_HP { get; set; }
    public abstract int HP { get; set; }
    public abstract int ATK { get; set; }
    public abstract int DEF { get; set; }
    public abstract void Print();
}

public class angry_mob: Zerg
{
    public override string Name { get; set; } = "성난 군중";
    public override int MAX_HP { get; set; } = 100;
    public override int HP { get; set; } = 100;
    public override int ATK { get; set; } = 10;
    public override int DEF { get; set; } = 0;
    public override void Print()
    {
        Console.WriteLine(@"
 ヽ(`Д´)ﾉ  ヽ(`Д´)ﾉ  ヽ(`Д´)ﾉ
   \|/        \|/        \|/
 -- + -------- + -------- + --
   / \        / \        / \

");
    }
}


//===============================================================아래 저그수치 0이상=======================================================================
public class Zergling : Zerg
{
    public override string Name { get; set; } = "저글링";
    public override int MAX_HP { get; set; } = 45;
    public override int HP { get; set; } = 45;
    public override int ATK { get; set; } = 5;
    public override int DEF { get; set; } = 0;
    public override void Print()
    {
        Console.WriteLine(@"
          /\_/\ 
      ___( o o )___
     /  _.-___-._  \
    |  /  .---.  \  |
    | |  | (o) |  |  |
    \ \   '--^--' / /
      '.'.___.___.''
         /|| ||\
     ___/ || || \___
   /____||||||||____\
");
    }
}


public class Raptor : Zerg
{
    public override string Name { get; set; } = "랩터";
    public override int MAX_HP { get; set; } = 80;
    public override int HP { get; set; } = 80;
    public override int ATK { get; set; } = 10;
    public override int DEF { get; set; } = 5;
    public override void Print()
    {
        Console.WriteLine(@"
      /\__
   ____/  _ \___
  /   _   (_)    >
 <   / \__   __ /
  \__\    \_/  \
       \___     \___
            \_____/==
");
    }
}


public class Roach : Zerg
{
    public override string Name { get; set; } = "바퀴";
    public override int MAX_HP { get; set; } = 160;
    public override int HP { get; set; } = 160;
    public override int ATK { get; set; } = 5;
    public override int DEF { get; set; } = 15;
    public override void Print()
    {
        Console.WriteLine(@"
      \  /
    (______ )
   _/  /\  \_
  /   /  \   \
   \    ||   /
    \___||__/
");
    }
}

public class Ravager : Zerg
{
    public override string Name { get; set; } = "궤멸충";
    public override int MAX_HP { get; set; } = 220;
    public override int HP { get; set; } = 220;
    public override int ATK { get; set; } = 15;
    public override int DEF { get; set; } = 0;
    public override void Print()
    {
        Console.WriteLine(@"
       \_/
     (_____ )
   _/   |   \_
  /   \  |  /   \
      \ | /
       \|/

");
    }
}

//===============================================================아래 저그수치 10이상======================================================================

public class Mutalisk : Zerg
{
    public override string Name { get; set; } = "뮤탈리스크";
    public override int MAX_HP { get; set; } = 350;
    public override int HP { get; set; } = 350;
    public override int ATK { get; set; } = 25;
    public override int DEF { get; set; } = 10;
    public override void Print()
    {
        Console.WriteLine(@"
         _________
   ____/         \____
 _/   (   )            \
/      \________________\
\        \   _/\_/\_/\_
 \        \_/          \
  \        /   _/\_     \
   \______/___/    \_____\>
               \_
                \__
");
    }
}

public class Scourge : Zerg
{
    public override string Name { get; set; } = "스커지";
    public override int MAX_HP { get; set; } = 100;
    public override int HP { get; set; } = 100;
    public override int ATK { get; set; } = 100;
    public override int DEF { get; set; } = 0;
    public override void Print()
    {
        Console.WriteLine(@"
           _____________
     ____/             \____
  __/     \____             \__
_/              \_______________\
\      \\\\\\\\_____///////       \
 \          \\\\____////           \
  \              ____                >
   \___________ /    \________________)
                \____/
");
    }
}

public class Hydralisk : Zerg
{
    public override string Name { get; set; } = "히드라리스크";
    public override int MAX_HP { get; set; } = 500;
    public override int HP { get; set; } = 500;
    public override int ATK { get; set; } = 25;
    public override int DEF { get; set; } = 10;
    public override void Print()
    {
        Console.WriteLine(@"
    .-'''-.
    .'   x x  '.
   |     (___)    |
    \              /
      '-._           _
           '-._      |
                ||
   ___====____====||====____====___
 |        __/       ||       \__        |
  \        \__       ||       __/       /
    '-._                _.-'
          '-.___          |
                   ||
                 __||__
");
    }
}


//===============================================================아래 저그수치 20이상======================================================================

public class Giant_Roach : Zerg
{
    public override string Name { get; set; } = "거대바퀴";
    public override int MAX_HP { get; set; } = 650;
    public override int HP { get; set; } = 650;
    public override int ATK { get; set; } = 45;
    public override int DEF { get; set; } = 45;
    public override void Print()
    {
        Console.WriteLine(@"
             ~  *
               |
          ___--^--___
     ___/      ____    \___
   _/        __/    \__        \_
  |        _/    ____    \_        |
   \        \      ____      /        /
     '-._      '-._            _.-'
            '-.___               |
                  ||     ||
      ___====____||_____| |____====___
   __/      __/    \__    | |    __      \__
 _/        _/    _/\_     \_|_|_/  \_        \_

");
    }
}

public class Spore_Crawler : Zerg
{
    public override string Name { get; set; } = "포자촉수";
    public override int MAX_HP { get; set; } = 1200;
    public override int HP { get; set; } = 1200;
    public override int ATK { get; set; } = 75;
    public override int DEF { get; set; } = 0;
    public override void Print()
    {
        Console.WriteLine(@"
          ~   *      ~
               |
         ___---(*)---___
     ___/        ___        \___
   _/          __/   \__            \_
  |          _/     (___)      \_          |
   \          \        ___        /         /
     '-._        '-._                _.-'
            '-.___                    |
   ~~~\        ~~~\   ||   /~~~        /~~~
       '-._          \__||__/          _.-'
             '-.___                     '

");
    }
}

public class Spine_Crawler : Zerg
{
    public override string Name { get; set; } = "가시촉수";
    public override int MAX_HP { get; set; } = 1200;
    public override int HP { get; set; } = 1200;
    public override int ATK { get; set; } = 25;
    public override int DEF { get; set; } = 50;
    public override void Print()
    {
        Console.WriteLine(@"
          ^    ^        ^
                 |
        ___---(X)---___
    ___/         ___         \___
  _/           __/   \__             \_
 |           _/        ___       \_           |
  \           \            ___        /          /
    '-._           '-._                     _.-'
           '-.___                          |
   ^^^\        ^^^\     ||     /^^^        /^^^
        '-._             \__||__/            _.-'
              '-.___                          '
");
    }
}

public class Raptor_Pack : Zerg
{
    public override string Name { get; set; } = "랩터무리";
    public override int MAX_HP { get; set; } = 450;
    public override int HP { get; set; } = 450;
    public override int ATK { get; set; } = 100;
    public override int DEF { get; set; } = 100;
    public override void Print()
    {
        Console.WriteLine(@"
     /\_/\        /\_/\
 /\_/\ x x /\_/\ x x /\_/\
( x ) > ^ < ( x ) > ^ < ( x )
 \_/   \___/  \_/   \___/  \_/

     /\_/\        /\_/\
 /\_/\ x x /\_/\ x x /\_/\
( x ) > ^ < ( x ) > ^ < ( x )
 \_/   \___/  \_/   \___/  \_/
");
    }
}

//===============================================================아래 저그수치 30이상======================================================================

public class Venom_Bug: Zerg
{
    public override string Name { get; set; } = "폭독충";
    public override int MAX_HP { get; set; } = 1500;
    public override int HP { get; set; } = 1500;
    public override int ATK { get; set; } = 200;
    public override int DEF { get; set; } = 100;
    public override void Print()
    {
        Console.WriteLine(@"
        /\__/\
     __/  ☣ ☣ \__
   _/   .-====-.   \_
  /    /  ######\     \
 |    |  ## ☢ ## |     |
 |     \  ######/     /
  \      '-.______.-'
   \__        ||
      \__     ||   
         \____||__~~~*~~*
              ||   ~~~*~~~
        __=====/\====__
    ___/     _/  \_     \___
  _/        _/      \_        \_
 (_________/          \_________)
");
    }
}

public class Lurker : Zerg
{
    public override string Name { get; set; } = "가시지옥";
    public override int MAX_HP { get; set; } = 650;
    public override int HP { get; set; } = 650;
    public override int ATK { get; set; } = 1000;
    public override int DEF { get; set; } = 250;
    public override void Print()
    {
        Console.WriteLine(@"
-----------------------------------------
              (      )
           .-'   ◉      ◉   '-.
        .-'        ___▁___         '-.
      .'        .-'   ▽   '-.            '.
     |         |     █████     |              |
      '.         '-.________.-'             .'
        '-._                                   _.-'
              '-._        |||||||        _.-'
                     '._   |||||||   _.-'
                          '|||||||'");
    }
}

public class Mutant_Hydralisk : Zerg
{
    public override string Name { get; set; } = "돌연변이_거대히드라";
    public override int MAX_HP { get; set; } = 3300;
    public override int HP { get; set; } = 3300;
    public override int ATK { get; set; } = 150;
    public override int DEF { get; set; } = 50;
    public override void Print()
    {
        Console.WriteLine(@"
            /\ 
           /  \__
      ____/       \__
    _/   ___   ___    \
   /    /   \_/   \_   |
  |    |   (  o o  )   |
  |     \     ___     /
  |      '-._.'   '-._'
  |        ||  ||  ||
  |   _____||__||__||_____
   \_/      ||  ||  ||    \
      \     ||  ||  ||     |
       |    ||  ||  ||     |
      /     ||  ||  ||      \
     /   ___/|__||__|\___     \
     \__/      \____/     \____/
");
    }
}

//===============================================================아래 저그수치 40이상======================================================================

public class Guardian : Zerg
{
    public override string Name { get; set; } = "수호군주";
    public override int MAX_HP { get; set; } = 5500;
    public override int HP { get; set; } = 5500;
    public override int ATK { get; set; } = 500;
    public override int DEF { get; set; } = 250;
    public override void Print()
    {
        Console.WriteLine(@"
       __..-._
  .-'  _.-'\
 /   .-'  _ \
|  .'    (_)|
 \  '-._      _
   '-._  '-._/ \
      '-._     /
   .-._   '-._/
  /   '-._    \
 |  .-._   '-._|
  \_/   '-._/
     /\    /\
    /__\__/__\
");
    }
}

public class Devourer : Zerg
{
    public override string Name { get; set; } = "포식군주";
    public override int MAX_HP { get; set; } = 2200;
    public override int HP { get; set; } = 2200;
    public override int ATK { get; set; } = 2000;
    public override int DEF { get; set; } = 150;
    public override void Print()
    {
        Console.WriteLine(@"
          ,--.
        _.-'  _ `-._
     .-'     .' `.     '-.
   .'       /  .-. \        '.
  /       .-|  | |  |-.        \
 |      .'  |  | |  |  '.        |
 |     /    |  |_|  |    \       |
 |    |      \      /      |     |
  \    \       '._._.'       /   /
   '.    '.          ___   .'   .'
     '-._    '-._..-'   `-'-._.-'
          '--..__              \
");
    }
}

public class Viper : Zerg
{
    public override string Name { get; set; } = "살모사";
    public override int MAX_HP { get; set; } = 4000;
    public override int HP { get; set; } = 4000;
    public override int ATK { get; set; } = 500;
    public override int DEF { get; set; } = 250;
    public override void Print()
    {
        Console.WriteLine(@"
            /\ 
      __..-'  `-..__
   .-'   _..---.._   `-.
  /   .-'   .-^^-. `-.   \
 |   /     /  .--.\    \   |
 |  |     |  |  || |    |  |
  \  \     \  '--' /   /  /
   '.  '-._   '-.__.-'  _.'
      '-.     ^^^     .-'
          '-._      .-'
               `-.__'
");
    }
}

//===============================================================이하 엑스트라======================================================================

public class Shelter_residents: Zerg
{
    public override string Name { get; set; } = "쉘터주민들";
    public override int MAX_HP { get; set; } = 500;
    public override int HP { get; set; } = 500;
    public override int ATK { get; set; } = 50;
    public override int DEF { get; set; } = 50;
    public override void Print()
    {
        Console.WriteLine(@"
(ಠ益ಠ) (ಠ益ಠ) (ಠ益ಠ)
   /|_\   /|_\   /|_\
  /_| |_\/_| |_\/_| |_\
");
    }
}

public class UnknownHostiles : Zerg
{
    public override string Name { get; set; } = "의문의 괴한들";
    public override int MAX_HP { get; set; } = 3000;
    public override int HP { get; set; } = 3000;
    public override int ATK { get; set; } = 750;
    public override int DEF { get; set; } = 750;
    public override void Print()
    {
        Console.WriteLine(@"
   _______      _______      _______
  |  ###  |    |  ###  |    |  ###  |
  |  ---  |    |  ---  |    |  ---  |
   \_____/      \_____/      \_____/
      ||            ||            ||
   ___||___      ___||___      ___||___
  /___||___\    /___||___\    /___||___\");
    }
}

public class ToxicSwarm : Zerg
{
    public override string Name { get; set; } = "독성 괴저그떼무리";
    public override int MAX_HP { get; set; } = 6500;
    public override int HP { get; set; } = 6500;
    public override int ATK { get; set; } = 1250;
    public override int DEF { get; set; } = 1250;
    public override void Print()
    {
        Console.WriteLine(@"
      (x_x)~   (O_O)~   (x_x)~
     (O_O)~   (x_x)~   (O_O)~
  (x_x)~   (O_O)~   (x_x)~   (O_O)~

      /|#\     /|#\     /|#\
     / |#\    / |#\    / |#\
      / \      / \      / \

  ~~~ ~~~ ~~~ ~~~ ~~~ ~~~ ~~~
");
    }
}

public class Aberration : Zerg
{
    public override string Name { get; set; } = "변형체";
    public override int MAX_HP { get; set; } = 22500;
    public override int HP { get; set; } = 22500;
    public override int ATK { get; set; } = 3175;
    public override int DEF { get; set; } = 1557;
    public override void Print()
    {
        Console.WriteLine(@"
       .-""-.
      .'  _    '.
     |   (○)      |
      \     __   /
        '-._||_.-'
        ___||___
   .-.-'    ||    '-.-.
  |    .----||----.     |
   '-._'----||----'_..-'
        '-.__||__.'
             \\
              '-._");
    }
}

public class Torrasque : Zerg
{
    public override string Name { get; set; } = "토라스크";
    public override int MAX_HP { get; set; } = 55341;
    public override int HP { get; set; } = 55341;
    public override int ATK { get; set; } = 12000;
    public override int DEF { get; set; } = 5500;
    public override void Print()
    {
        Console.WriteLine(@"
  ___====>--------------------.
 /  _.-'   ___        ___      \
|.-'      .-'   '-. .-'   '-.    |
||        |   (##)  X  (##)   |   |
||         '-.____.-' '-.____.-'  |
||      ___        ___        ___/
 \__..-'   '-.__.-'   '-.__.-'
");
    }
}

public class Toxic_Mucosa: Zerg
{
    public override string Name { get; set; } = "독성점막";
    public override int MAX_HP { get; set; } = 22222;
    public override int HP { get; set; } = 22222;
    public override int ATK { get; set; } = 666;
    public override int DEF { get; set; } = 6666;
    public override void Print()
    {
        Console.WriteLine(@"
☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣
==[  x  ]===[===☢ CORE ☢===]====[  x  ]==
~~~~~\____/~~~~~~~|||~~~~~~~\____/~~~~~
☠☠☠   ==>>==>>==>>|||<<==<<==<<==   ☠☠☠
~~~~~/_==_\~~~~~~~|||~~~~~~~/_==_\~~~~~
==[  x  ]===[===☣ ACID ☣===]====[  x  ]==
☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣☣");
    }
}