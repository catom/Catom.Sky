using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Algorithm;

/// <summary>
/// Taohua 的摘要说明
/// </summary>

public class TaoHua
{
    public string sex = "";

    int count = 0;
    public string XCduanyu = "";
    public string HYduanyu = "";
    public string CZduanyu = "";
    public string BYduanyu = "";
    public string LTduanyu = "";
    public string LHduanyu = "";
    public string JCduanyu = "";
    public string NYduanyu = "";
    public string XWduanyu = "";
    public string QYduanyu = "";
    public string BZduanyu = "";
    public string SLduanyu = "";
    public string tiangan = "";
    //咸池桃花
    public void GetXianChiTaoHua()
    {
        count = 0;
        if (BaZi.rDiZhi == "寅" && (BaZi.nDiZhi == "卯" || BaZi.yDiZhi == "卯" || BaZi.sDiZhi == "卯"))
        {
            if (BaZi.nDiZhi == "卯")
            {
                count++;
            }
            if (BaZi.yDiZhi == "卯")
            {
                count++;
            }
            if (BaZi.sDiZhi == "卯")
            {
                count++;
            }
            if (count == 1)
            {
                XCduanyu = "命中有1朵咸池桃花" + " 在你的身上有着或内或外的闪光点，而这些闪光点总能吸引异性倾心于你，幸福往往悄然而至，请好好把握。";
            }
            else if (count == 2)
            {
                XCduanyu = "命中有2朵咸池桃花" + " 不得不承认，在寻找爱情的道路上，你拥有很多优势，除了气质和外表，更难能可贵的是你其实很擅长表达自己的感情。不过，也请你在被粉红色环绕的时候冷静下来，毕竟人生旅途中并不需要过多的旅伴，不是么？";
            }
            else if (count == 3)
            {
                XCduanyu = "命中有3朵咸池桃花" + " 你极其容易获得异性的关注，这种与生俱来的吸引力让你十分耀眼。对你来说表达感情从来不是问题，或许暴露感情才是。请小心的使用自己的这份力量，人生有更加广阔的天地值得去探索。";
            }
            else
            {
                XCduanyu = "命中没有咸池桃花" + " 你恐怕并不是一个擅长表达感情的人，“风流倜傥”对你来说绝对是算不上合适的形容词。但冷静的心态和沉稳的气质是你最大的财富，请好好珍惜。";
            }
        }


        else if (BaZi.rDiZhi == "午" && (BaZi.nDiZhi == "卯" || BaZi.yDiZhi == "卯" || BaZi.sDiZhi == "卯"))
        {
            count = 0;
            if (BaZi.nDiZhi == "卯")
            {
                count++;
            }
            if (BaZi.yDiZhi == "卯")
            {
                count++;
            }
            if (BaZi.sDiZhi == "卯")
            {
                count++;
            }
            if (count == 1)
            {
                XCduanyu = "命中有1朵咸池桃花" + " 在你的身上有着或内或外的闪光点，而这些闪光点总能吸引异性倾心于你，幸福往往悄然而至，请好好把握。";
            }
            else if (count == 2)
            {
                XCduanyu = "命中有2朵咸池桃花" + " 不得不承认，在寻找爱情的道路上，你拥有很多优势，除了气质和外表，更难能可贵的是你其实很擅长表达自己的感情。不过，也请你在被粉红色环绕的时候冷静下来，毕竟人生旅途中并不需要过多的旅伴，不是么？";
            }
            else if (count == 3)
            {
                XCduanyu = "命中有3朵咸池桃花" + " 你极其容易获得异性的关注，这种与生俱来的吸引力让你十分耀眼。对你来说表达感情从来不是问题，或许暴露感情才是。请小心的使用自己的这份力量，人生有更加广阔的天地值得去探索。";
            }
            else
            {
                XCduanyu = "命中没有咸池桃花" + " 你恐怕并不是一个擅长表达感情的人，“风流倜傥”对你来说绝对是算不上合适的形容词。但冷静的心态和沉稳的气质是你最大的财富，请好好珍惜。";
            }
        }


        else if (BaZi.rDiZhi == "戌" && (BaZi.nDiZhi == "卯" || BaZi.yDiZhi == "卯" || BaZi.sDiZhi == "卯"))
        {
            count = 0;
            if (BaZi.nDiZhi == "卯")
            {
                count++;
            }
            if (BaZi.yDiZhi == "卯")
            {
                count++;
            }
            if (BaZi.sDiZhi == "卯")
            {
                count++;
            }
            if (count == 1)
            {
                XCduanyu = "命中有1朵咸池桃花" + " 在你的身上有着或内或外的闪光点，而这些闪光点总能吸引异性倾心于你，幸福往往悄然而至，请好好把握。";
            }
            else if (count == 2)
            {
                XCduanyu = "命中有2朵咸池桃花" + " 不得不承认，在寻找爱情的道路上，你拥有很多优势，除了气质和外表，更难能可贵的是你其实很擅长表达自己的感情。不过，也请你在被粉红色环绕的时候冷静下来，毕竟人生旅途中并不需要过多的旅伴，不是么？";
            }
            else if (count == 3)
            {
                XCduanyu = "命中有3朵咸池桃花" + " 你极其容易获得异性的关注，这种与生俱来的吸引力让你十分耀眼。对你来说表达感情从来不是问题，或许暴露感情才是。请小心的使用自己的这份力量，人生有更加广阔的天地值得去探索。";
            }
            else
            {
                XCduanyu = "命中没有咸池桃花" + " 你恐怕并不是一个擅长表达感情的人，“风流倜傥”对你来说绝对是算不上合适的形容词。但冷静的心态和沉稳的气质是你最大的财富，请好好珍惜。";
            }
        }

        else if (BaZi.rDiZhi == "申" && (BaZi.nDiZhi == "酉" || BaZi.yDiZhi == "酉" || BaZi.sDiZhi == "酉"))
        {
            count = 0;
            if (BaZi.nDiZhi == "酉")
            {
                count++;
            }
            if (BaZi.yDiZhi == "酉")
            {
                count++;
            }
            if (BaZi.sDiZhi == "酉")
            {
                count++;
            }
            if (count == 1)
            {
                XCduanyu = "命中有1朵咸池桃花" + " 在你的身上有着或内或外的闪光点，而这些闪光点总能吸引异性倾心于你，幸福往往悄然而至，请好好把握。";
            }
            else if (count == 2)
            {
                XCduanyu = "命中有2朵咸池桃花" + " 不得不承认，在寻找爱情的道路上，你拥有很多优势，除了气质和外表，更难能可贵的是你其实很擅长表达自己的感情。不过，也请你在被粉红色环绕的时候冷静下来，毕竟人生旅途中并不需要过多的旅伴，不是么？";
            }
            else if (count == 3)
            {
                XCduanyu = "命中有3朵咸池桃花" + " 你极其容易获得异性的关注，这种与生俱来的吸引力让你十分耀眼。对你来说表达感情从来不是问题，或许暴露感情才是。请小心的使用自己的这份力量，人生有更加广阔的天地值得去探索。";
            }
            else
            {
                XCduanyu = "命中没有咸池桃花" + " 你恐怕并不是一个擅长表达感情的人，“风流倜傥”对你来说绝对是算不上合适的形容词。但冷静的心态和沉稳的气质是你最大的财富，请好好珍惜。";
            }
        }

        else if (BaZi.rDiZhi == "子" && (BaZi.nDiZhi == "酉" || BaZi.yDiZhi == "酉" || BaZi.sDiZhi == "酉"))
        {
            count = 0;
            if (BaZi.nDiZhi == "酉")
            {
                count++;
            }
            if (BaZi.yDiZhi == "酉")
            {
                count++;
            }
            if (BaZi.sDiZhi == "酉")
            {
                count++;
            }
            if (count == 1)
            {
                XCduanyu = "命中有1朵咸池桃花" + " 在你的身上有着或内或外的闪光点，而这些闪光点总能吸引异性倾心于你，幸福往往悄然而至，请好好把握。";
            }
            else if (count == 2)
            {
                XCduanyu = "命中有2朵咸池桃花" + " 不得不承认，在寻找爱情的道路上，你拥有很多优势，除了气质和外表，更难能可贵的是你其实很擅长表达自己的感情。不过，也请你在被粉红色环绕的时候冷静下来，毕竟人生旅途中并不需要过多的旅伴，不是么？";
            }
            else if (count == 3)
            {
                XCduanyu = "命中有3朵咸池桃花" + " 你极其容易获得异性的关注，这种与生俱来的吸引力让你十分耀眼。对你来说表达感情从来不是问题，或许暴露感情才是。请小心的使用自己的这份力量，人生有更加广阔的天地值得去探索。";
            }
            else
            {
                XCduanyu = "命中没有咸池桃花" + " 你恐怕并不是一个擅长表达感情的人，“风流倜傥”对你来说绝对是算不上合适的形容词。但冷静的心态和沉稳的气质是你最大的财富，请好好珍惜。";
            }
        }

        else if (BaZi.rDiZhi == "辰" && (BaZi.nDiZhi == "酉" || BaZi.yDiZhi == "酉" || BaZi.sDiZhi == "酉"))
        {
            count = 0;
            if (BaZi.nDiZhi == "酉")
            {
                count++;
            }
            if (BaZi.yDiZhi == "酉")
            {
                count++;
            }
            if (BaZi.sDiZhi == "酉")
            {
                count++;
            }
            if (count == 1)
            {
                XCduanyu = "命中有1朵咸池桃花" + " 在你的身上有着或内或外的闪光点，而这些闪光点总能吸引异性倾心于你，幸福往往悄然而至，请好好把握。";
            }
            else if (count == 2)
            {
                XCduanyu = "命中有2朵咸池桃花" + " 不得不承认，在寻找爱情的道路上，你拥有很多优势，除了气质和外表，更难能可贵的是你其实很擅长表达自己的感情。不过，也请你在被粉红色环绕的时候冷静下来，毕竟人生旅途中并不需要过多的旅伴，不是么？";
            }
            else if (count == 3)
            {
                XCduanyu = "命中有3朵咸池桃花" + " 你极其容易获得异性的关注，这种与生俱来的吸引力让你十分耀眼。对你来说表达感情从来不是问题，或许暴露感情才是。请小心的使用自己的这份力量，人生有更加广阔的天地值得去探索。";
            }
            else
            {
                XCduanyu = "命中没有咸池桃花" + " 你恐怕并不是一个擅长表达感情的人，“风流倜傥”对你来说绝对是算不上合适的形容词。但冷静的心态和沉稳的气质是你最大的财富，请好好珍惜。";
            }
        }


        else if (BaZi.rDiZhi == "亥" && (BaZi.nDiZhi == "子" || BaZi.yDiZhi == "子" || BaZi.sDiZhi == "子"))
        {
            count = 0;
            if (BaZi.nDiZhi == "子")
            {
                count++;
            }
            if (BaZi.yDiZhi == "子")
            {
                count++;
            }
            if (BaZi.sDiZhi == "子")
            {
                count++;
            }
            if (count == 1)
            {
                XCduanyu = "命中有1朵咸池桃花" + " 在你的身上有着或内或外的闪光点，而这些闪光点总能吸引异性倾心于你，幸福往往悄然而至，请好好把握。";
            }
            else if (count == 2)
            {
                XCduanyu = "命中有2朵咸池桃花" + " 不得不承认，在寻找爱情的道路上，你拥有很多优势，除了气质和外表，更难能可贵的是你其实很擅长表达自己的感情。不过，也请你在被粉红色环绕的时候冷静下来，毕竟人生旅途中并不需要过多的旅伴，不是么？";
            }
            else if (count == 3)
            {
                XCduanyu = "命中有3朵咸池桃花" + " 你极其容易获得异性的关注，这种与生俱来的吸引力让你十分耀眼。对你来说表达感情从来不是问题，或许暴露感情才是。请小心的使用自己的这份力量，人生有更加广阔的天地值得去探索。";
            }
            else
            {
                XCduanyu = "命中没有咸池桃花" + " 你恐怕并不是一个擅长表达感情的人，“风流倜傥”对你来说绝对是算不上合适的形容词。但冷静的心态和沉稳的气质是你最大的财富，请好好珍惜。";
            }
        }

        else if (BaZi.rDiZhi == "卯" && (BaZi.nDiZhi == "子" || BaZi.yDiZhi == "子" || BaZi.sDiZhi == "子"))
        {
            count = 0;
            if (BaZi.nDiZhi == "子")
            {
                count++;
            }
            if (BaZi.yDiZhi == "子")
            {
                count++;
            }
            if (BaZi.sDiZhi == "子")
            {
                count++;
            }
            if (count == 1)
            {
                XCduanyu = "命中有1朵咸池桃花" + " 在你的身上有着或内或外的闪光点，而这些闪光点总能吸引异性倾心于你，幸福往往悄然而至，请好好把握。";
            }
            else if (count == 2)
            {
                XCduanyu = "命中有2朵咸池桃花" + " 不得不承认，在寻找爱情的道路上，你拥有很多优势，除了气质和外表，更难能可贵的是你其实很擅长表达自己的感情。不过，也请你在被粉红色环绕的时候冷静下来，毕竟人生旅途中并不需要过多的旅伴，不是么？";
            }
            else if (count == 3)
            {
                XCduanyu = "命中有3朵咸池桃花" + " 你极其容易获得异性的关注，这种与生俱来的吸引力让你十分耀眼。对你来说表达感情从来不是问题，或许暴露感情才是。请小心的使用自己的这份力量，人生有更加广阔的天地值得去探索。";
            }
            else
            {
                XCduanyu = "命中没有咸池桃花" + " 你恐怕并不是一个擅长表达感情的人，“风流倜傥”对你来说绝对是算不上合适的形容词。但冷静的心态和沉稳的气质是你最大的财富，请好好珍惜。";
            }
        }

        else if (BaZi.rDiZhi == "未" && (BaZi.nDiZhi == "子" || BaZi.yDiZhi == "子" || BaZi.sDiZhi == "子"))
        {
            count = 0;
            if (BaZi.nDiZhi == "子")
            {
                count++;
            }
            if (BaZi.yDiZhi == "子")
            {
                count++;
            }
            if (BaZi.sDiZhi == "子")
            {
                count++;
            }
            if (count == 1)
            {
                XCduanyu = "命中有1朵咸池桃花" + " 在你的身上有着或内或外的闪光点，而这些闪光点总能吸引异性倾心于你，幸福往往悄然而至，请好好把握。";
            }
            else if (count == 2)
            {
                XCduanyu = "命中有2朵咸池桃花" + " 不得不承认，在寻找爱情的道路上，你拥有很多优势，除了气质和外表，更难能可贵的是你其实很擅长表达自己的感情。不过，也请你在被粉红色环绕的时候冷静下来，毕竟人生旅途中并不需要过多的旅伴，不是么？";
            }
            else if (count == 3)
            {
                XCduanyu = "命中有3朵咸池桃花" + " 你极其容易获得异性的关注，这种与生俱来的吸引力让你十分耀眼。对你来说表达感情从来不是问题，或许暴露感情才是。请小心的使用自己的这份力量，人生有更加广阔的天地值得去探索。";
            }
            else
            {
                XCduanyu = "命中没有咸池桃花" + " 你恐怕并不是一个擅长表达感情的人，“风流倜傥”对你来说绝对是算不上合适的形容词。但冷静的心态和沉稳的气质是你最大的财富，请好好珍惜。";
            }
        }

        else if (BaZi.rDiZhi == "巳" && (BaZi.nDiZhi == "午" || BaZi.yDiZhi == "午" || BaZi.sDiZhi == "午"))
        {
            count = 0;
            if (BaZi.nDiZhi == "午")
            {
                count++;
            }
            if (BaZi.yDiZhi == "午")
            {
                count++;
            }
            if (BaZi.sDiZhi == "午")
            {
                count++;
            }
            if (count == 1)
            {
                XCduanyu = "命中有1朵咸池桃花" + " 在你的身上有着或内或外的闪光点，而这些闪光点总能吸引异性倾心于你，幸福往往悄然而至，请好好把握。";
            }
            else if (count == 2)
            {
                XCduanyu = "命中有2朵咸池桃花" + " 不得不承认，在寻找爱情的道路上，你拥有很多优势，除了气质和外表，更难能可贵的是你其实很擅长表达自己的感情。不过，也请你在被粉红色环绕的时候冷静下来，毕竟人生旅途中并不需要过多的旅伴，不是么？";
            }
            else if (count == 3)
            {
                XCduanyu = "命中有3朵咸池桃花" + " 你极其容易获得异性的关注，这种与生俱来的吸引力让你十分耀眼。对你来说表达感情从来不是问题，或许暴露感情才是。请小心的使用自己的这份力量，人生有更加广阔的天地值得去探索。";
            }
            else
            {
                XCduanyu = "命中没有咸池桃花" + " 你恐怕并不是一个擅长表达感情的人，“风流倜傥”对你来说绝对是算不上合适的形容词。但冷静的心态和沉稳的气质是你最大的财富，请好好珍惜。";
            }
        }

        else if (BaZi.rDiZhi == "酉" && (BaZi.nDiZhi == "午" || BaZi.yDiZhi == "午" || BaZi.sDiZhi == "午"))
        {
            count = 0;
            if (BaZi.nDiZhi == "午")
            {
                count++;
            }
            if (BaZi.yDiZhi == "午")
            {
                count++;
            }
            if (BaZi.sDiZhi == "午")
            {
                count++;
            }
            if (count == 1)
            {
                XCduanyu = "命中有1朵咸池桃花" + " 在你的身上有着或内或外的闪光点，而这些闪光点总能吸引异性倾心于你，幸福往往悄然而至，请好好把握。";
            }
            else if (count == 2)
            {
                XCduanyu = "命中有2朵咸池桃花" + " 不得不承认，在寻找爱情的道路上，你拥有很多优势，除了气质和外表，更难能可贵的是你其实很擅长表达自己的感情。不过，也请你在被粉红色环绕的时候冷静下来，毕竟人生旅途中并不需要过多的旅伴，不是么？";
            }
            else if (count == 3)
            {
                XCduanyu = "命中有3朵咸池桃花" + " 你极其容易获得异性的关注，这种与生俱来的吸引力让你十分耀眼。对你来说表达感情从来不是问题，或许暴露感情才是。请小心的使用自己的这份力量，人生有更加广阔的天地值得去探索。";
            }
            else
            {
                XCduanyu = "命中没有咸池桃花" + " 你恐怕并不是一个擅长表达感情的人，“风流倜傥”对你来说绝对是算不上合适的形容词。但冷静的心态和沉稳的气质是你最大的财富，请好好珍惜。";
            }
        }

        else if (BaZi.rDiZhi == "丑" && (BaZi.nDiZhi == "午" || BaZi.yDiZhi == "午" || BaZi.sDiZhi == "午"))
        {
            count = 0;
            if (BaZi.nDiZhi == "午")
            {
                count++;
            }
            if (BaZi.yDiZhi == "午")
            {
                count++;
            }
            if (BaZi.sDiZhi == "午")
            {
                count++;
            }
            if (count == 1)
            {
                XCduanyu = "命中有1朵咸池桃花" + " 在你的身上有着或内或外的闪光点，而这些闪光点总能吸引异性倾心于你，幸福往往悄然而至，请好好把握。";
            }
            else if (count == 2)
            {
                XCduanyu = "命中有2朵咸池桃花" + " 不得不承认，在寻找爱情的道路上，你拥有很多优势，除了气质和外表，更难能可贵的是你其实很擅长表达自己的感情。不过，也请你在被粉红色环绕的时候冷静下来，毕竟人生旅途中并不需要过多的旅伴，不是么？";
            }
            else if (count == 3)
            {
                XCduanyu = "命中有3朵咸池桃花" + " 你极其容易获得异性的关注，这种与生俱来的吸引力让你十分耀眼。对你来说表达感情从来不是问题，或许暴露感情才是。请小心的使用自己的这份力量，人生有更加广阔的天地值得去探索。";
            }
            else
            {
                XCduanyu = "命中没有咸池桃花" + " 你恐怕并不是一个擅长表达感情的人，“风流倜傥”对你来说绝对是算不上合适的形容词。但冷静的心态和沉稳的气质是你最大的财富，请好好珍惜。";
            }
        }
        else
        {
            XCduanyu = "命中没有咸池桃花" + " 你恐怕并不是一个擅长表达感情的人，“风流倜傥”对你来说绝对是算不上合适的形容词。但冷静的心态和沉稳的气质是你最大的财富，请好好珍惜。";
        }
    }

    //红艳桃花
    public void GetHongYanTaoHua()
    {
        count = 0;
        if ((BaZi.nTianGan == "甲" || BaZi.rTianGan == "甲") && (BaZi.nDiZhi == "午" || BaZi.yDiZhi == "午" || BaZi.rDiZhi == "午" || BaZi.sDiZhi == "午"))
        {
            if (BaZi.nDiZhi == "午")
            {
                count++;
            }
            if (BaZi.yDiZhi == "午")
            {
                count++;
            }
            if (BaZi.rDiZhi == "午")
            {
                count++;
            }
            if (BaZi.sDiZhi == "午")
            {
                count++;
            }
            if (count == 1)
            {
                HYduanyu = "命中有1朵红艳煞桃花" + " 你其实有着不错的人缘，也并非不擅表达自己的感情，良缘可遇而不可求，遇到喜欢的人请牢牢抓住不要放手。";
            }
            else if (count == 2)
            {
                HYduanyu = "命中有2朵红艳煞桃花" + " 很多人会憧憬你丰富多彩的感情世界，也会羡慕你浪漫多情的气质，自然如此迷人的你，必然会有异性向你流露感情。而你，恐怕也会欣然接受吧。";
            }
            else if (count == 3)
            {
                HYduanyu = "命中有3朵红艳煞桃花" + " 当多情的你撞上纠缠的缘分，要面对的不只是甜蜜，而是更多的挑战。即使已心有所属，但魅力出众的你仍会吸引异性的追求，请你保持清醒，保护好自己，也保护好自己所爱的人。";
            }
            else if (count == 4)
            {
                HYduanyu = "命中有4朵红艳煞桃花" + " 你有着超人的吸引力，然而这令你的感情世界复杂得像一座迷宫。也许你已经对此游刃有余，但是也请你时时审视自己是否已经不知不觉间迷路。";
            }
            else
            {
                HYduanyu = "命中没有红艳煞桃花" + " 你的感情世界虽然平淡，但令人安心，一见钟情火速配对式的浪漫并不适合你。你的感情大概会从相识已久的朋友身上慢慢滋生，虽然平淡，但贵在踏实。";
            }
        }


        else if ((BaZi.nTianGan == "乙" || BaZi.rTianGan == "乙") && (BaZi.nDiZhi == "午" || BaZi.yDiZhi == "午" || BaZi.rDiZhi == "午" || BaZi.sDiZhi == "午"))
        {
            count = 0;
            if (BaZi.nDiZhi == "午")
            {
                count++;
            }
            if (BaZi.yDiZhi == "午")
            {
                count++;
            }
            if (BaZi.rDiZhi == "午")
            {
                count++;
            }
            if (BaZi.sDiZhi == "午")
            {
                count++;
            }
            if (count == 1)
            {
                HYduanyu = "命中有1朵红艳煞桃花" + " 你其实有着不错的人缘，也并非不擅表达自己的感情，良缘可遇而不可求，遇到喜欢的人请牢牢抓住不要放手。";
            }
            else if (count == 2)
            {
                HYduanyu = "命中有2朵红艳煞桃花" + " 很多人会憧憬你丰富多彩的感情世界，也会羡慕你浪漫多情的气质，自然如此迷人的你，必然会有异性向你流露感情。而你，恐怕也会欣然接受吧。";
            }
            else if (count == 3)
            {
                HYduanyu = "命中有3朵红艳煞桃花" + " 当多情的你撞上纠缠的缘分，要面对的不只是甜蜜，而是更多的挑战。即使已心有所属，但魅力出众的你仍会吸引异性的追求，请你保持清醒，保护好自己，也保护好自己所爱的人。";
            }
            else if (count == 4)
            {
                HYduanyu = "命中有4朵红艳煞桃花" + " 你有着超人的吸引力，然而这令你的感情世界复杂得像一座迷宫。也许你已经对此游刃有余，但是也请你时时审视自己是否已经不知不觉间迷路。";
            }
            else
            {
                HYduanyu = "命中没有红艳煞桃花" + " 你的感情世界虽然平淡，但令人安心，一见钟情火速配对式的浪漫并不适合你。你的感情大概会从相识已久的朋友身上慢慢滋生，虽然平淡，但贵在踏实。";
            }
        }


        else if ((BaZi.nTianGan == "丙" || BaZi.rTianGan == "丙") && (BaZi.nDiZhi == "寅" || BaZi.yDiZhi == "寅" || BaZi.rDiZhi == "寅" || BaZi.sDiZhi == "寅"))
        {
            count = 0;
            if (BaZi.nDiZhi == "寅")
            {
                count++;
            }
            if (BaZi.yDiZhi == "寅")
            {
                count++;
            }
            if (BaZi.rDiZhi == "寅")
            {
                count++;
            }
            if (BaZi.sDiZhi == "寅")
            {
                count++;
            }
            if (count == 1)
            {
                HYduanyu = "命中有1朵红艳煞桃花" + " 你其实有着不错的人缘，也并非不擅表达自己的感情，良缘可遇而不可求，遇到喜欢的人请牢牢抓住不要放手。";
            }
            else if (count == 2)
            {
                HYduanyu = "命中有2朵红艳煞桃花" + " 很多人会憧憬你丰富多彩的感情世界，也会羡慕你浪漫多情的气质，自然如此迷人的你，必然会有异性向你流露感情。而你，恐怕也会欣然接受吧。";
            }
            else if (count == 3)
            {
                HYduanyu = "命中有3朵红艳煞桃花" + " 当多情的你撞上纠缠的缘分，要面对的不只是甜蜜，而是更多的挑战。即使已心有所属，但魅力出众的你仍会吸引异性的追求，请你保持清醒，保护好自己，也保护好自己所爱的人。";
            }
            else if (count == 4)
            {
                HYduanyu = "命中有4朵红艳煞桃花" + " 你有着超人的吸引力，然而这令你的感情世界复杂得像一座迷宫。也许你已经对此游刃有余，但是也请你时时审视自己是否已经不知不觉间迷路。";
            }
            else
            {
                HYduanyu = "命中没有红艳煞桃花" + " 你的感情世界虽然平淡，但令人安心，一见钟情火速配对式的浪漫并不适合你。你的感情大概会从相识已久的朋友身上慢慢滋生，虽然平淡，但贵在踏实。";
            }
        }


        else if ((BaZi.nTianGan == "丁" || BaZi.rTianGan == "丁") && (BaZi.nDiZhi == "未" || BaZi.yDiZhi == "未" || BaZi.rDiZhi == "未" || BaZi.sDiZhi == "未"))
        {
            count = 0;
            if (BaZi.nDiZhi == "未")
            {
                count++;
            }
            if (BaZi.yDiZhi == "未")
            {
                count++;
            }
            if (BaZi.rDiZhi == "未")
            {
                count++;
            }
            if (BaZi.sDiZhi == "未")
            {
                count++;
            }
            if (count == 1)
            {
                HYduanyu = "命中有1朵红艳煞桃花" + " 你其实有着不错的人缘，也并非不擅表达自己的感情，良缘可遇而不可求，遇到喜欢的人请牢牢抓住不要放手。";
            }
            else if (count == 2)
            {
                HYduanyu = "命中有2朵红艳煞桃花" + " 很多人会憧憬你丰富多彩的感情世界，也会羡慕你浪漫多情的气质，自然如此迷人的你，必然会有异性向你流露感情。而你，恐怕也会欣然接受吧。";
            }
            else if (count == 3)
            {
                HYduanyu = "命中有3朵红艳煞桃花" + " 当多情的你撞上纠缠的缘分，要面对的不只是甜蜜，而是更多的挑战。即使已心有所属，但魅力出众的你仍会吸引异性的追求，请你保持清醒，保护好自己，也保护好自己所爱的人。";
            }
            else if (count == 4)
            {
                HYduanyu = "命中有4朵红艳煞桃花" + " 你有着超人的吸引力，然而这令你的感情世界复杂得像一座迷宫。也许你已经对此游刃有余，但是也请你时时审视自己是否已经不知不觉间迷路。";
            }
            else
            {
                HYduanyu = "命中没有红艳煞桃花" + " 你的感情世界虽然平淡，但令人安心，一见钟情火速配对式的浪漫并不适合你。你的感情大概会从相识已久的朋友身上慢慢滋生，虽然平淡，但贵在踏实。";
            }
        }


        else if ((BaZi.nTianGan == "戊" || BaZi.rTianGan == "戊") && (BaZi.nDiZhi == "辰" || BaZi.yDiZhi == "辰" || BaZi.rDiZhi == "辰" || BaZi.sDiZhi == "辰"))
        {
            count = 0;
            if (BaZi.nDiZhi == "辰")
            {
                count++;
            }
            if (BaZi.yDiZhi == "辰")
            {
                count++;
            }
            if (BaZi.rDiZhi == "辰")
            {
                count++;
            }
            if (BaZi.sDiZhi == "辰")
            {
                count++;
            }
            if (count == 1)
            {
                HYduanyu = "命中有1朵红艳煞桃花" + " 你其实有着不错的人缘，也并非不擅表达自己的感情，良缘可遇而不可求，遇到喜欢的人请牢牢抓住不要放手。";
            }
            else if (count == 2)
            {
                HYduanyu = "命中有2朵红艳煞桃花" + " 很多人会憧憬你丰富多彩的感情世界，也会羡慕你浪漫多情的气质，自然如此迷人的你，必然会有异性向你流露感情。而你，恐怕也会欣然接受吧。";
            }
            else if (count == 3)
            {
                HYduanyu = "命中有3朵红艳煞桃花" + " 当多情的你撞上纠缠的缘分，要面对的不只是甜蜜，而是更多的挑战。即使已心有所属，但魅力出众的你仍会吸引异性的追求，请你保持清醒，保护好自己，也保护好自己所爱的人。";
            }
            else if (count == 4)
            {
                HYduanyu = "命中有4朵红艳煞桃花" + " 你有着超人的吸引力，然而这令你的感情世界复杂得像一座迷宫。也许你已经对此游刃有余，但是也请你时时审视自己是否已经不知不觉间迷路。";
            }
            else
            {
                HYduanyu = "命中没有红艳煞桃花" + " 你的感情世界虽然平淡，但令人安心，一见钟情火速配对式的浪漫并不适合你。你的感情大概会从相识已久的朋友身上慢慢滋生，虽然平淡，但贵在踏实。";
            }
        }


        else if ((BaZi.nTianGan == "己" || BaZi.rTianGan == "己") && (BaZi.nDiZhi == "辰" || BaZi.yDiZhi == "辰" || BaZi.rDiZhi == "辰" || BaZi.sDiZhi == "辰"))
        {
            count = 0;
            if (BaZi.nDiZhi == "辰")
            {
                count++;
            }
            if (BaZi.yDiZhi == "辰")
            {
                count++;
            }
            if (BaZi.rDiZhi == "辰")
            {
                count++;
            }
            if (BaZi.sDiZhi == "辰")
            {
                count++;
            }
            if (count == 1)
            {
                HYduanyu = "命中有1朵红艳煞桃花" + " 你其实有着不错的人缘，也并非不擅表达自己的感情，良缘可遇而不可求，遇到喜欢的人请牢牢抓住不要放手。";
            }
            else if (count == 2)
            {
                HYduanyu = "命中有2朵红艳煞桃花" + " 很多人会憧憬你丰富多彩的感情世界，也会羡慕你浪漫多情的气质，自然如此迷人的你，必然会有异性向你流露感情。而你，恐怕也会欣然接受吧。";
            }
            else if (count == 3)
            {
                HYduanyu = "命中有3朵红艳煞桃花" + " 当多情的你撞上纠缠的缘分，要面对的不只是甜蜜，而是更多的挑战。即使已心有所属，但魅力出众的你仍会吸引异性的追求，请你保持清醒，保护好自己，也保护好自己所爱的人。";
            }
            else if (count == 4)
            {
                HYduanyu = "命中有4朵红艳煞桃花" + " 你有着超人的吸引力，然而这令你的感情世界复杂得像一座迷宫。也许你已经对此游刃有余，但是也请你时时审视自己是否已经不知不觉间迷路。";
            }
            else
            {
                HYduanyu = "命中没有红艳煞桃花" + " 你的感情世界虽然平淡，但令人安心，一见钟情火速配对式的浪漫并不适合你。你的感情大概会从相识已久的朋友身上慢慢滋生，虽然平淡，但贵在踏实。";
            }
        }


        else if ((BaZi.nTianGan == "庚" || BaZi.rTianGan == "庚") && (BaZi.nDiZhi == "戌" || BaZi.yDiZhi == "戌" || BaZi.rDiZhi == "戌" || BaZi.sDiZhi == "戌"))
        {
            count = 0;
            if (BaZi.nDiZhi == "戌")
            {
                count++;
            }
            if (BaZi.yDiZhi == "戌")
            {
                count++;
            }
            if (BaZi.rDiZhi == "戌")
            {
                count++;
            }
            if (BaZi.sDiZhi == "戌")
            {
                count++;
            }
            if (count == 1)
            {
                HYduanyu = "命中有1朵红艳煞桃花" + " 你其实有着不错的人缘，也并非不擅表达自己的感情，良缘可遇而不可求，遇到喜欢的人请牢牢抓住不要放手。";
            }
            else if (count == 2)
            {
                HYduanyu = "命中有2朵红艳煞桃花" + " 很多人会憧憬你丰富多彩的感情世界，也会羡慕你浪漫多情的气质，自然如此迷人的你，必然会有异性向你流露感情。而你，恐怕也会欣然接受吧。";
            }
            else if (count == 3)
            {
                HYduanyu = "命中有3朵红艳煞桃花" + " 当多情的你撞上纠缠的缘分，要面对的不只是甜蜜，而是更多的挑战。即使已心有所属，但魅力出众的你仍会吸引异性的追求，请你保持清醒，保护好自己，也保护好自己所爱的人。";
            }
            else if (count == 4)
            {
                HYduanyu = "命中有4朵红艳煞桃花" + " 你有着超人的吸引力，然而这令你的感情世界复杂得像一座迷宫。也许你已经对此游刃有余，但是也请你时时审视自己是否已经不知不觉间迷路。";
            }
            else
            {
                HYduanyu = "命中没有红艳煞桃花" + " 你的感情世界虽然平淡，但令人安心，一见钟情火速配对式的浪漫并不适合你。你的感情大概会从相识已久的朋友身上慢慢滋生，虽然平淡，但贵在踏实。";
            }
        }



        else if ((BaZi.nTianGan == "辛" || BaZi.rTianGan == "辛") && (BaZi.nDiZhi == "酉" || BaZi.yDiZhi == "酉" || BaZi.rDiZhi == "酉" || BaZi.sDiZhi == "酉"))
        {
            count = 0;
            if (BaZi.nDiZhi == "酉")
            {
                count++;
            }
            if (BaZi.yDiZhi == "酉")
            {
                count++;
            }
            if (BaZi.rDiZhi == "酉")
            {
                count++;
            }
            if (BaZi.sDiZhi == "酉")
            {
                count++;
            }
            if (count == 1)
            {
                HYduanyu = "命中有1朵红艳煞桃花" + " 你其实有着不错的人缘，也并非不擅表达自己的感情，良缘可遇而不可求，遇到喜欢的人请牢牢抓住不要放手。";
            }
            else if (count == 2)
            {
                HYduanyu = "命中有2朵红艳煞桃花" + " 很多人会憧憬你丰富多彩的感情世界，也会羡慕你浪漫多情的气质，自然如此迷人的你，必然会有异性向你流露感情。而你，恐怕也会欣然接受吧。";
            }
            else if (count == 3)
            {
                HYduanyu = "命中有3朵红艳煞桃花" + " 当多情的你撞上纠缠的缘分，要面对的不只是甜蜜，而是更多的挑战。即使已心有所属，但魅力出众的你仍会吸引异性的追求，请你保持清醒，保护好自己，也保护好自己所爱的人。";
            }
            else if (count == 4)
            {
                HYduanyu = "命中有4朵红艳煞桃花" + " 你有着超人的吸引力，然而这令你的感情世界复杂得像一座迷宫。也许你已经对此游刃有余，但是也请你时时审视自己是否已经不知不觉间迷路。";
            }
            else
            {
                HYduanyu = "命中没有红艳煞桃花" + " 你的感情世界虽然平淡，但令人安心，一见钟情火速配对式的浪漫并不适合你。你的感情大概会从相识已久的朋友身上慢慢滋生，虽然平淡，但贵在踏实。";
            }
        }


        else if ((BaZi.nTianGan == "壬" || BaZi.rTianGan == "壬") && (BaZi.nDiZhi == "子" || BaZi.yDiZhi == "子" || BaZi.rDiZhi == "子" || BaZi.sDiZhi == "子"))
        {
            count = 0;
            if (BaZi.nDiZhi == "子")
            {
                count++;
            }
            if (BaZi.yDiZhi == "子")
            {
                count++;
            }
            if (BaZi.rDiZhi == "子")
            {
                count++;
            }
            if (BaZi.sDiZhi == "子")
            {
                count++;
            }
            if (count == 1)
            {
                HYduanyu = "命中有1朵红艳煞桃花" + " 你其实有着不错的人缘，也并非不擅表达自己的感情，良缘可遇而不可求，遇到喜欢的人请牢牢抓住不要放手。";
            }
            else if (count == 2)
            {
                HYduanyu = "命中有2朵红艳煞桃花" + " 很多人会憧憬你丰富多彩的感情世界，也会羡慕你浪漫多情的气质，自然如此迷人的你，必然会有异性向你流露感情。而你，恐怕也会欣然接受吧。";
            }
            else if (count == 3)
            {
                HYduanyu = "命中有3朵红艳煞桃花" + " 当多情的你撞上纠缠的缘分，要面对的不只是甜蜜，而是更多的挑战。即使已心有所属，但魅力出众的你仍会吸引异性的追求，请你保持清醒，保护好自己，也保护好自己所爱的人。";
            }
            else if (count == 4)
            {
                HYduanyu = "命中有4朵红艳煞桃花" + " 你有着超人的吸引力，然而这令你的感情世界复杂得像一座迷宫。也许你已经对此游刃有余，但是也请你时时审视自己是否已经不知不觉间迷路。";
            }
            else
            {
                HYduanyu = "命中没有红艳煞桃花" + " 你的感情世界虽然平淡，但令人安心，一见钟情火速配对式的浪漫并不适合你。你的感情大概会从相识已久的朋友身上慢慢滋生，虽然平淡，但贵在踏实。";
            }
        }



        else if ((BaZi.nTianGan == "癸" || BaZi.rTianGan == "癸") && (BaZi.nDiZhi == "丑" || BaZi.yDiZhi == "丑" || BaZi.rDiZhi == "丑" || BaZi.sDiZhi == "丑"))
        {
            count = 0;
            if (BaZi.nDiZhi == "丑")
            {
                count++;
            }
            if (BaZi.yDiZhi == "丑")
            {
                count++;
            }
            if (BaZi.rDiZhi == "丑")
            {
                count++;
            }
            if (BaZi.sDiZhi == "丑")
            {
                count++;
            }
            if (count == 1)
            {
                HYduanyu = "命中有1朵红艳煞桃花" + " 你其实有着不错的人缘，也并非不擅表达自己的感情，良缘可遇而不可求，遇到喜欢的人请牢牢抓住不要放手。";
            }
            else if (count == 2)
            {
                HYduanyu = "命中有2朵红艳煞桃花" + " 很多人会憧憬你丰富多彩的感情世界，也会羡慕你浪漫多情的气质，自然如此迷人的你，必然会有异性向你流露感情。而你，恐怕也会欣然接受吧。";
            }
            else if (count == 3)
            {
                HYduanyu = "命中有3朵红艳煞桃花" + " 当多情的你撞上纠缠的缘分，要面对的不只是甜蜜，而是更多的挑战。即使已心有所属，但魅力出众的你仍会吸引异性的追求，请你保持清醒，保护好自己，也保护好自己所爱的人。";
            }
            else if (count == 4)
            {
                HYduanyu = "命中有4朵红艳煞桃花" + " 你有着超人的吸引力，然而这令你的感情世界复杂得像一座迷宫。也许你已经对此游刃有余，但是也请你时时审视自己是否已经不知不觉间迷路。";
            }
            else
            {
                HYduanyu = "命中没有红艳煞桃花" + " 你的感情世界虽然平淡，但令人安心，一见钟情火速配对式的浪漫并不适合你。你的感情大概会从相识已久的朋友身上慢慢滋生，虽然平淡，但贵在踏实。";
            }
        }
        else
        {
            HYduanyu = "命中没有红艳煞桃花" + " 你的感情世界虽然平淡，但令人安心，一见钟情火速配对式的浪漫并不适合你。你的感情大概会从相识已久的朋友身上慢慢滋生，虽然平淡，但贵在踏实。";
        }

    }

    //插枝桃花
    public void GetChaZhiTaoHua()
    {
        if (BaZi.yDiZhi == "子" && (BaZi.rDiZhi == "申" || BaZi.rDiZhi == "辰"))
        {
            CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
        }
        else if (BaZi.yDiZhi == "丑" && (BaZi.rDiZhi == "巳" || BaZi.rDiZhi == "酉"))
        {
            CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
        }
        else if (BaZi.yDiZhi == "寅" && (BaZi.rDiZhi == "午" || BaZi.rDiZhi == "戌"))
        {
            CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
        }
        else if (BaZi.yDiZhi == "卯" && (BaZi.rDiZhi == "亥" || BaZi.rDiZhi == "未"))
        {
            CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
        }
        else if (BaZi.yDiZhi == "辰" && (BaZi.rDiZhi == "申" || BaZi.rDiZhi == "子"))
        {
            CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
        }
        else if (BaZi.yDiZhi == "巳" && (BaZi.rDiZhi == "酉" || BaZi.rDiZhi == "丑"))
        {
            CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
        }
        else if (BaZi.yDiZhi == "午" && (BaZi.rDiZhi == "寅" || BaZi.rDiZhi == "戌"))
        {
            CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
        }
        else if (BaZi.yDiZhi == "未" && (BaZi.rDiZhi == "亥" || BaZi.rDiZhi == "卯"))
        {
            CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
        }
        else if (BaZi.yDiZhi == "申" && (BaZi.rDiZhi == "子" || BaZi.rDiZhi == "辰"))
        {
            CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
        }
        else if (BaZi.yDiZhi == "酉" && (BaZi.rDiZhi == "巳" || BaZi.rDiZhi == "丑"))
        {
            CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
        }
        else if (BaZi.yDiZhi == "戌" && (BaZi.rDiZhi == "寅" || BaZi.rDiZhi == "午"))
        {
            CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
        }
        else if (BaZi.yDiZhi == "亥" && (BaZi.rDiZhi == "卯" || BaZi.rDiZhi == "未"))
        {
            CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
        }
        else
        {
            CZduanyu = "命中没有插枝桃花" + " 一番耕耘，一番收获。爱情的果实从来不是从天而降的礼物，它需要你精心的呵护和耐心的等待。";
        }
    }

    //遍野桃花
    public void GetBianYeTaoHua()
    {
        count = 0;
        if (BaZi.nDiZhi == "子" || BaZi.nDiZhi == " 午" || BaZi.nDiZhi == " 卯" || BaZi.nDiZhi == " 酉")
        {
            count++;
        }
        if (BaZi.yDiZhi == "子" || BaZi.yDiZhi == " 午" || BaZi.yDiZhi == " 卯" || BaZi.yDiZhi == " 酉")
        {
            count++;
        }
        if (BaZi.rDiZhi == "子" || BaZi.rDiZhi == " 午" || BaZi.rDiZhi == " 卯" || BaZi.rDiZhi == " 酉")
        {
            count++;
        }
        if (BaZi.sDiZhi == "子" || BaZi.sDiZhi == " 午" || BaZi.sDiZhi == " 卯" || BaZi.sDiZhi == " 酉")
        {
            count++;
        }
        if (count >= 3)
        {
            BYduanyu = "命中有1朵遍野桃花" + " 你的内心无比渴望爱情，而爱情也如你所愿地纷至沓来。你不会苦恼于如何把握住爱情，但你恐怕会苦恼于在纠缠的姻缘里如何做出选择。";
        }
        else
        {
            BYduanyu = "命中没有遍野桃花" + " 你的内心渴望着相伴终生的伴侣，但人类作为社会性动物的生存状态下，你偶尔也会出去寻求一下刺激或者被短暂的迷惑。请坚守自己的本心，毕竟人生那么长。";
        }
    }

    //裸体桃花
    public void GetLuoTiTaoHua()
    {
        if (BaZi.rizhu == "甲子" || BaZi.rizhu == "丁卯" || BaZi.rizhu == "庚午" || BaZi.rizhu == "癸酉")
        {
            LTduanyu = "命中有1朵裸体桃花" + " 你对自己的外表恐怕并不缺乏信心，甚至会在日常穿着中有意无意的炫耀这一点。你可以很好地驾驭时髦的衣服打扮，甚至包括布料最少的那一部分。真是令人羡慕的资本。";
        }
        else
        {
            LTduanyu = "命中没有裸体桃花" + " 你更倾向于保守的个人形象，而对比较暴露的服饰兴趣不高甚至反感。裸睡恐怕也不是你的兴趣，一套柔软、宽松、舒适的睡衣更加适合你的胃口。";
        }
    }

    //六合桃花
    public void GetLiuHeTaoHua()
    {
        count = 0;
        if (BaZi.rTianGan == "甲" && (ZangGan.yz.Contains("巳") || ZangGan.rz.Contains("巳") || ZangGan.sz.Contains("巳")))
        {
            if (ZangGan.yzhanggan[0] == "巳" || ZangGan.yzhanggan[1] == "巳" || ZangGan.yzhanggan[2] == "巳")
            {
                count++;
            }
            else if (ZangGan.rzhanggan[0] == "巳" || ZangGan.rzhanggan[1] == "巳" || ZangGan.rzhanggan[2] == "巳")
            {
                count++;
            }
            else if (ZangGan.szhanggan[0] == "巳" || ZangGan.szhanggan[1] == "巳" || ZangGan.szhanggan[2] == "巳")
            {
                count++;
            }
            if (count == 1)
            {
                LHduanyu = "命中有1朵六合桃花" + " 对于另一半，你总是摆出了一副亲老婆还是亲老公都得明算账的姿态。然而实际上，你总会默默地多承担一点东西。你小心地隐藏着自己对感情的需求，但实际上却藏不住。你精心地维护者与情人的关系，但是却没有更多额外的要求。";
            }
            else if (count == 2)
            {
                LHduanyu = "命中有2朵六合桃花" + " 成为你的情人是幸福的，因为专一的你并非那种患得患失之人。虽然你的无私其实是你对他或者她强烈依恋的证据，但为了这份幸福，哪怕多付出一点对你来说也是值得的。";
            }
            else if (count == 3)
            {
                LHduanyu = "命中有3朵六合桃花" + " 对于伴侣，你像圣骑士一般无私和忠诚，这既是你的耀眼光环，也是你对爱情强烈依赖心理的表现。一段爱情的破灭对你而言几乎是毁灭性的打击。试着在付出的同时更多地索求一点吧，毕竟恋爱是两个人的事。";
            }
            else
            {
                LHduanyu = "命中没有六合桃花" + " 从你的行为看来，感情更像是一门你来我往互通有无的生意。在付出的同时，你也期待着收获。而当收获低于预期的时候，你也会果断地下调老情人的优先级。";
            }
        }

        if (BaZi.rTianGan == "乙" && (ZangGan.yz.Contains("庚") || ZangGan.rz.Contains("庚") || ZangGan.sz.Contains("庚")))
        {
            if (ZangGan.yzhanggan[0] == "庚" || ZangGan.yzhanggan[1] == "庚" || ZangGan.yzhanggan[2] == "庚")
            {
                count++;
            }
            else if (ZangGan.rzhanggan[0] == "庚" || ZangGan.rzhanggan[1] == "庚" || ZangGan.rzhanggan[2] == "庚")
            {
                count++;
            }
            else if (ZangGan.szhanggan[0] == "庚" || ZangGan.szhanggan[1] == "庚" || ZangGan.szhanggan[2] == "庚")
            {
                count++;
            }
            if (count == 1)
            {
                LHduanyu = "命中有1朵六合桃花" + " 对于另一半，你总是摆出了一副亲老婆还是亲老公都得明算账的姿态。然而实际上，你总会默默地多承担一点东西。你小心地隐藏着自己对感情的需求，但实际上却藏不住。你精心地维护者与情人的关系，但是却没有更多额外的要求。";
            }
            else if (count == 2)
            {
                LHduanyu = "命中有2朵六合桃花" + " 成为你的情人是幸福的，因为专一的你并非那种患得患失之人。虽然你的无私其实是你对他或者她强烈依恋的证据，但为了这份幸福，哪怕多付出一点对你来说也是值得的。";
            }
            else if (count == 3)
            {
                LHduanyu = "命中有3朵六合桃花" + " 对于伴侣，你像圣骑士一般无私和忠诚，这既是你的耀眼光环，也是你对爱情强烈依赖心理的表现。一段爱情的破灭对你而言几乎是毁灭性的打击。试着在付出的同时更多地索求一点吧，毕竟恋爱是两个人的事。";
            }
            else
            {
                LHduanyu = "命中没有六合桃花" + " 从你的行为看来，感情更像是一门你来我往互通有无的生意。在付出的同时，你也期待着收获。而当收获低于预期的时候，你也会果断地下调老情人的优先级。";
            }
        }

        if (BaZi.rTianGan == "丙" && (ZangGan.yz.Contains("辛") || ZangGan.rz.Contains("辛") || ZangGan.sz.Contains("辛")))
        {
            if (ZangGan.yzhanggan[0] == "辛" || ZangGan.yzhanggan[1] == "辛" || ZangGan.yzhanggan[2] == "辛")
            {
                count++;
            }
            else if (ZangGan.rzhanggan[0] == "辛" || ZangGan.rzhanggan[1] == "辛" || ZangGan.rzhanggan[2] == "辛")
            {
                count++;
            }
            else if (ZangGan.szhanggan[0] == "辛" || ZangGan.szhanggan[1] == "辛" || ZangGan.szhanggan[2] == "辛")
            {
                count++;
            }
            if (count == 1)
            {
                LHduanyu = "命中有1朵六合桃花" + " 对于另一半，你总是摆出了一副亲老婆还是亲老公都得明算账的姿态。然而实际上，你总会默默地多承担一点东西。你小心地隐藏着自己对感情的需求，但实际上却藏不住。你精心地维护者与情人的关系，但是却没有更多额外的要求。";
            }
            else if (count == 2)
            {
                LHduanyu = "命中有2朵六合桃花" + " 成为你的情人是幸福的，因为专一的你并非那种患得患失之人。虽然你的无私其实是你对他或者她强烈依恋的证据，但为了这份幸福，哪怕多付出一点对你来说也是值得的。";
            }
            else if (count == 3)
            {
                LHduanyu = "命中有3朵六合桃花" + " 对于伴侣，你像圣骑士一般无私和忠诚，这既是你的耀眼光环，也是你对爱情强烈依赖心理的表现。一段爱情的破灭对你而言几乎是毁灭性的打击。试着在付出的同时更多地索求一点吧，毕竟恋爱是两个人的事。";
            }
            else
            {
                LHduanyu = "命中没有六合桃花" + " 从你的行为看来，感情更像是一门你来我往互通有无的生意。在付出的同时，你也期待着收获。而当收获低于预期的时候，你也会果断地下调老情人的优先级。";
            }
        }

        if (BaZi.rTianGan == "丁" && (ZangGan.yz.Contains("壬") || ZangGan.rz.Contains("壬") || ZangGan.sz.Contains("壬")))
        {
            if (ZangGan.yzhanggan[0] == "壬" || ZangGan.yzhanggan[1] == "壬" || ZangGan.yzhanggan[2] == "壬")
            {
                count++;
            }
            else if (ZangGan.rzhanggan[0] == "壬" || ZangGan.rzhanggan[1] == "壬" || ZangGan.rzhanggan[2] == "壬")
            {
                count++;
            }
            else if (ZangGan.szhanggan[0] == "壬" || ZangGan.szhanggan[1] == "壬" || ZangGan.szhanggan[2] == "壬")
            {
                count++;
            }
            if (count == 1)
            {
                LHduanyu = "命中有1朵六合桃花" + " 对于另一半，你总是摆出了一副亲老婆还是亲老公都得明算账的姿态。然而实际上，你总会默默地多承担一点东西。你小心地隐藏着自己对感情的需求，但实际上却藏不住。你精心地维护者与情人的关系，但是却没有更多额外的要求。";
            }
            else if (count == 2)
            {
                LHduanyu = "命中有2朵六合桃花" + " 成为你的情人是幸福的，因为专一的你并非那种患得患失之人。虽然你的无私其实是你对他或者她强烈依恋的证据，但为了这份幸福，哪怕多付出一点对你来说也是值得的。";
            }
            else if (count == 3)
            {
                LHduanyu = "命中有3朵六合桃花" + " 对于伴侣，你像圣骑士一般无私和忠诚，这既是你的耀眼光环，也是你对爱情强烈依赖心理的表现。一段爱情的破灭对你而言几乎是毁灭性的打击。试着在付出的同时更多地索求一点吧，毕竟恋爱是两个人的事。";
            }
            else
            {
                LHduanyu = "命中没有六合桃花" + " 从你的行为看来，感情更像是一门你来我往互通有无的生意。在付出的同时，你也期待着收获。而当收获低于预期的时候，你也会果断地下调老情人的优先级。";
            }
        }

        if (BaZi.rTianGan == "戊" && (ZangGan.yz.Contains("癸") || ZangGan.rz.Contains("癸") || ZangGan.sz.Contains("癸")))
        {
            if (ZangGan.yzhanggan[0] == "癸" || ZangGan.yzhanggan[1] == "癸" || ZangGan.yzhanggan[2] == "癸")
            {
                count++;
            }
            else if (ZangGan.rzhanggan[0] == "癸" || ZangGan.rzhanggan[1] == "癸" || ZangGan.rzhanggan[2] == "癸")
            {
                count++;
            }
            else if (ZangGan.szhanggan[0] == "癸" || ZangGan.szhanggan[1] == "癸" || ZangGan.szhanggan[2] == "癸")
            {
                count++;
            }
            if (count == 1)
            {
                LHduanyu = "命中有1朵六合桃花" + " 对于另一半，你总是摆出了一副亲老婆还是亲老公都得明算账的姿态。然而实际上，你总会默默地多承担一点东西。你小心地隐藏着自己对感情的需求，但实际上却藏不住。你精心地维护者与情人的关系，但是却没有更多额外的要求。";
            }
            else if (count == 2)
            {
                LHduanyu = "命中有2朵六合桃花" + " 成为你的情人是幸福的，因为专一的你并非那种患得患失之人。虽然你的无私其实是你对他或者她强烈依恋的证据，但为了这份幸福，哪怕多付出一点对你来说也是值得的。";
            }
            else if (count == 3)
            {
                LHduanyu = "命中有3朵六合桃花" + " 对于伴侣，你像圣骑士一般无私和忠诚，这既是你的耀眼光环，也是你对爱情强烈依赖心理的表现。一段爱情的破灭对你而言几乎是毁灭性的打击。试着在付出的同时更多地索求一点吧，毕竟恋爱是两个人的事。";
            }
            else
            {
                LHduanyu = "命中没有六合桃花" + " 从你的行为看来，感情更像是一门你来我往互通有无的生意。在付出的同时，你也期待着收获。而当收获低于预期的时候，你也会果断地下调老情人的优先级。";
            }
        }
        if (BaZi.rTianGan == "己" && (ZangGan.yz.Contains("甲") || ZangGan.rz.Contains("甲") || ZangGan.sz.Contains("甲")))
        {
            if (ZangGan.yzhanggan[0] == "甲" || ZangGan.yzhanggan[1] == "甲" || ZangGan.yzhanggan[2] == "甲")
            {
                count++;
            }
            else if (ZangGan.rzhanggan[0] == "甲" || ZangGan.rzhanggan[1] == "甲" || ZangGan.rzhanggan[2] == "甲")
            {
                count++;
            }
            else if (ZangGan.szhanggan[0] == "甲" || ZangGan.szhanggan[1] == "甲" || ZangGan.szhanggan[2] == "甲")
            {
                count++;
            }
            if (count == 1)
            {
                LHduanyu = "命中有1朵六合桃花" + " 对于另一半，你总是摆出了一副亲老婆还是亲老公都得明算账的姿态。然而实际上，你总会默默地多承担一点东西。你小心地隐藏着自己对感情的需求，但实际上却藏不住。你精心地维护者与情人的关系，但是却没有更多额外的要求。";
            }
            else if (count == 2)
            {
                LHduanyu = "命中有2朵六合桃花" + " 成为你的情人是幸福的，因为专一的你并非那种患得患失之人。虽然你的无私其实是你对他或者她强烈依恋的证据，但为了这份幸福，哪怕多付出一点对你来说也是值得的。";
            }
            else if (count == 3)
            {
                LHduanyu = "命中有3朵六合桃花" + " 对于伴侣，你像圣骑士一般无私和忠诚，这既是你的耀眼光环，也是你对爱情强烈依赖心理的表现。一段爱情的破灭对你而言几乎是毁灭性的打击。试着在付出的同时更多地索求一点吧，毕竟恋爱是两个人的事。";
            }
            else
            {
                LHduanyu = "命中没有六合桃花" + " 从你的行为看来，感情更像是一门你来我往互通有无的生意。在付出的同时，你也期待着收获。而当收获低于预期的时候，你也会果断地下调老情人的优先级。";
            }
        }

        if (BaZi.rTianGan == "庚" && (ZangGan.yz.Contains("乙") || ZangGan.rz.Contains("乙") || ZangGan.sz.Contains("乙")))
        {
            if (ZangGan.yzhanggan[0] == "乙" || ZangGan.yzhanggan[1] == "乙" || ZangGan.yzhanggan[2] == "乙")
            {
                count++;
            }
            else if (ZangGan.rzhanggan[0] == "乙" || ZangGan.rzhanggan[1] == "乙" || ZangGan.rzhanggan[2] == "乙")
            {
                count++;
            }
            else if (ZangGan.szhanggan[0] == "乙" || ZangGan.szhanggan[1] == "乙" || ZangGan.szhanggan[2] == "乙")
            {
                count++;
            }
            if (count == 1)
            {
                LHduanyu = "命中有1朵六合桃花" + " 对于另一半，你总是摆出了一副亲老婆还是亲老公都得明算账的姿态。然而实际上，你总会默默地多承担一点东西。你小心地隐藏着自己对感情的需求，但实际上却藏不住。你精心地维护者与情人的关系，但是却没有更多额外的要求。";
            }
            else if (count == 2)
            {
                LHduanyu = "命中有2朵六合桃花" + " 成为你的情人是幸福的，因为专一的你并非那种患得患失之人。虽然你的无私其实是你对他或者她强烈依恋的证据，但为了这份幸福，哪怕多付出一点对你来说也是值得的。";
            }
            else if (count == 3)
            {
                LHduanyu = "命中有3朵六合桃花" + " 对于伴侣，你像圣骑士一般无私和忠诚，这既是你的耀眼光环，也是你对爱情强烈依赖心理的表现。一段爱情的破灭对你而言几乎是毁灭性的打击。试着在付出的同时更多地索求一点吧，毕竟恋爱是两个人的事。";
            }
            else
            {
                LHduanyu = "命中没有六合桃花" + " 从你的行为看来，感情更像是一门你来我往互通有无的生意。在付出的同时，你也期待着收获。而当收获低于预期的时候，你也会果断地下调老情人的优先级。";
            }
        }

        if (BaZi.rTianGan == "辛" && (ZangGan.yz.Contains("丙") || ZangGan.rz.Contains("丙") || ZangGan.sz.Contains("丙")))
        {
            if (ZangGan.yzhanggan[0] == "丙" || ZangGan.yzhanggan[1] == "丙" || ZangGan.yzhanggan[2] == "丙")
            {
                count++;
            }
            else if (ZangGan.rzhanggan[0] == "丙" || ZangGan.rzhanggan[1] == "丙" || ZangGan.rzhanggan[2] == "丙")
            {
                count++;
            }
            else if (ZangGan.szhanggan[0] == "丙" || ZangGan.szhanggan[1] == "丙" || ZangGan.szhanggan[2] == "丙")
            {
                count++;
            }
            if (count == 1)
            {
                LHduanyu = "命中有1朵六合桃花" + " 对于另一半，你总是摆出了一副亲老婆还是亲老公都得明算账的姿态。然而实际上，你总会默默地多承担一点东西。你小心地隐藏着自己对感情的需求，但实际上却藏不住。你精心地维护者与情人的关系，但是却没有更多额外的要求。";
            }
            else if (count == 2)
            {
                LHduanyu = "命中有2朵六合桃花" + " 成为你的情人是幸福的，因为专一的你并非那种患得患失之人。虽然你的无私其实是你对他或者她强烈依恋的证据，但为了这份幸福，哪怕多付出一点对你来说也是值得的。";
            }
            else if (count == 3)
            {
                LHduanyu = "命中有3朵六合桃花" + " 对于伴侣，你像圣骑士一般无私和忠诚，这既是你的耀眼光环，也是你对爱情强烈依赖心理的表现。一段爱情的破灭对你而言几乎是毁灭性的打击。试着在付出的同时更多地索求一点吧，毕竟恋爱是两个人的事。";
            }
            else
            {
                LHduanyu = "命中没有六合桃花" + " 从你的行为看来，感情更像是一门你来我往互通有无的生意。在付出的同时，你也期待着收获。而当收获低于预期的时候，你也会果断地下调老情人的优先级。";
            }
        }

        if (BaZi.rTianGan == "壬" && (ZangGan.yz.Contains("丁") || ZangGan.rz.Contains("丁") || ZangGan.sz.Contains("丁")))
        {
            if (ZangGan.yzhanggan[0] == "丁" || ZangGan.yzhanggan[1] == "丁" || ZangGan.yzhanggan[2] == "丁")
            {
                count++;
            }
            else if (ZangGan.rzhanggan[0] == "丁" || ZangGan.rzhanggan[1] == "丁" || ZangGan.rzhanggan[2] == "丁")
            {
                count++;
            }
            else if (ZangGan.szhanggan[0] == "丁" || ZangGan.szhanggan[1] == "丁" || ZangGan.szhanggan[2] == "丁")
            {
                count++;
            }
            if (count == 1)
            {
                LHduanyu = "命中有1朵六合桃花" + " 对于另一半，你总是摆出了一副亲老婆还是亲老公都得明算账的姿态。然而实际上，你总会默默地多承担一点东西。你小心地隐藏着自己对感情的需求，但实际上却藏不住。你精心地维护者与情人的关系，但是却没有更多额外的要求。";
            }
            else if (count == 2)
            {
                LHduanyu = "命中有2朵六合桃花" + " 成为你的情人是幸福的，因为专一的你并非那种患得患失之人。虽然你的无私其实是你对他或者她强烈依恋的证据，但为了这份幸福，哪怕多付出一点对你来说也是值得的。";
            }
            else if (count == 3)
            {
                LHduanyu = "命中有3朵六合桃花" + " 对于伴侣，你像圣骑士一般无私和忠诚，这既是你的耀眼光环，也是你对爱情强烈依赖心理的表现。一段爱情的破灭对你而言几乎是毁灭性的打击。试着在付出的同时更多地索求一点吧，毕竟恋爱是两个人的事。";
            }
            else
            {
                LHduanyu = "命中没有六合桃花" + " 从你的行为看来，感情更像是一门你来我往互通有无的生意。在付出的同时，你也期待着收获。而当收获低于预期的时候，你也会果断地下调老情人的优先级。";
            }
        }

        if (BaZi.rTianGan == "癸" && (ZangGan.yz.Contains("戊") || ZangGan.rz.Contains("戊") || ZangGan.sz.Contains("戊")))
        {
            if (ZangGan.yzhanggan[0] == "戊" || ZangGan.yzhanggan[1] == "戊" || ZangGan.yzhanggan[2] == "戊")
            {
                count++;
            }
            else if (ZangGan.rzhanggan[0] == "戊" || ZangGan.rzhanggan[1] == "戊" || ZangGan.rzhanggan[2] == "戊")
            {
                count++;
            }
            else if (ZangGan.szhanggan[0] == "戊" || ZangGan.szhanggan[1] == "戊" || ZangGan.szhanggan[2] == "戊")
            {
                count++;
            }
            if (count == 1)
            {
                LHduanyu = "命中有1朵六合桃花" + " 对于另一半，你总是摆出了一副亲老婆还是亲老公都得明算账的姿态。然而实际上，你总会默默地多承担一点东西。你小心地隐藏着自己对感情的需求，但实际上却藏不住。你精心地维护者与情人的关系，但是却没有更多额外的要求。";
            }
            else if (count == 2)
            {
                LHduanyu = "命中有2朵六合桃花" + " 成为你的情人是幸福的，因为专一的你并非那种患得患失之人。虽然你的无私其实是你对他或者她强烈依恋的证据，但为了这份幸福，哪怕多付出一点对你来说也是值得的。";
            }
            else if (count == 3)
            {
                LHduanyu = "命中有3朵六合桃花" + " 对于伴侣，你像圣骑士一般无私和忠诚，这既是你的耀眼光环，也是你对爱情强烈依赖心理的表现。一段爱情的破灭对你而言几乎是毁灭性的打击。试着在付出的同时更多地索求一点吧，毕竟恋爱是两个人的事。";
            }
            else
            {
                LHduanyu = "命中没有六合桃花" + " 从你的行为看来，感情更像是一门你来我往互通有无的生意。在付出的同时，你也期待着收获。而当收获低于预期的时候，你也会果断地下调老情人的优先级。";
            }
        }

    }

    //九丑桃花
    public void GetJiuChouTaoHua()
    {

        if (BaZi.rizhu == "丁酉" || BaZi.rizhu == "戊子" || BaZi.rizhu == "戊午" || BaZi.rizhu == "己卯" || BaZi.rizhu == "己酉" || BaZi.rizhu == "辛卯" || BaZi.rizhu == "辛酉" || BaZi.rizhu == "壬子" || BaZi.rizhu == "壬午")
        {
            JCduanyu = "命中有1朵九丑桃花" + " 你并没有为自己的伴侣划定一条高不可攀的“及格线”，你不在乎对方是否腰缠万贯或者年轻貌美，个人财富和身世背景上的优劣对你而言不值一哂，最重要的只是重要的是";
        }
        else
        {
            JCduanyu = "命中没有九丑桃花" + " 作为一个社会人，你的择偶标准不可避免地受到了亲友尤其是长辈的影响，婚姻对你而言不仅仅是爱情的延续，更是一份涉及重大利益博弈的契约。而你也会理所当然地选择一位值得投资的伴侣。";
        }
    }

    //嫩芽桃花
    public void GetNenYaTaoHua()
    {
        if (BaZi.yDiZhi == "子" && (BaZi.sDiZhi == "丑" || BaZi.sDiZhi == "申" || BaZi.sDiZhi == "辰"))
        {
            NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
        }
        else if (BaZi.yDiZhi == "丑" && (BaZi.sDiZhi == "子" || BaZi.sDiZhi == "巳" || BaZi.sDiZhi == "酉"))
        {
            NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
        }
        else if (BaZi.yDiZhi == "寅" && (BaZi.sDiZhi == "亥" || BaZi.sDiZhi == "午" || BaZi.sDiZhi == "戌"))
        {
            NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
        }
        else if (BaZi.yDiZhi == "卯" && (BaZi.sDiZhi == "戌" || BaZi.sDiZhi == "亥" || BaZi.sDiZhi == "未"))
        {
            NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
        }
        else if (BaZi.yDiZhi == "辰" && (BaZi.sDiZhi == "酉" || BaZi.sDiZhi == "申" || BaZi.sDiZhi == "子"))
        {
            NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
        }
        else if (BaZi.yDiZhi == "巳" && (BaZi.sDiZhi == "申" || BaZi.sDiZhi == "酉" || BaZi.sDiZhi == "丑"))
        {
            NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
        }
        else if (BaZi.yDiZhi == "午" && (BaZi.sDiZhi == "未" || BaZi.sDiZhi == "寅" || BaZi.sDiZhi == "戌"))
        {
            NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
        }
        else if (BaZi.yDiZhi == "未" && (BaZi.sDiZhi == "午" || BaZi.sDiZhi == "亥" || BaZi.sDiZhi == "卯"))
        {
            NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
        }
        else if (BaZi.yDiZhi == "申" && (BaZi.sDiZhi == "巳" || BaZi.sDiZhi == "子" || BaZi.sDiZhi == "辰"))
        {
            NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
        }
        else if (BaZi.yDiZhi == "酉" && (BaZi.sDiZhi == "辰" || BaZi.sDiZhi == "巳" || BaZi.sDiZhi == "丑"))
        {
            NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
        }
        else if (BaZi.yDiZhi == "戌" && (BaZi.sDiZhi == "卯" || BaZi.sDiZhi == "寅" || BaZi.sDiZhi == "午"))
        {
            NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
        }
        else if (BaZi.yDiZhi == "亥" && (BaZi.sDiZhi == "寅" || BaZi.sDiZhi == "卯" || BaZi.sDiZhi == "未"))
        {
            NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
        }
        else
        {
            NYduanyu = "命中没有嫩芽桃花" + " 年龄比你小很多的异性和你相恋的概率并不大。当然，事事都有偶然。";
        }
    }

    //玄武桃花
    public void GetXuanWuTaoHua()
    {
        if (BaZi.yDiZhi == "子" && (BaZi.nDiZhi == "丑" || BaZi.nDiZhi == "申" || BaZi.nDiZhi == "辰"))
        {
            XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
        }

        else if (BaZi.yDiZhi == "丑" && (BaZi.nDiZhi == "子" || BaZi.nDiZhi == "巳" || BaZi.nDiZhi == "酉"))
        {
            XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
        }

        else if (BaZi.yDiZhi == "寅" && (BaZi.nDiZhi == "亥" || BaZi.nDiZhi == "午" || BaZi.nDiZhi == "戌"))
        {
            XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
        }

        else if (BaZi.yDiZhi == "卯" && (BaZi.nDiZhi == "戌" || BaZi.nDiZhi == "亥" || BaZi.nDiZhi == "未"))
        {
            XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
        }

        else if (BaZi.yDiZhi == "辰" && (BaZi.nDiZhi == "酉" || BaZi.nDiZhi == "申" || BaZi.nDiZhi == "子"))
        {
            XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
        }

        else if (BaZi.yDiZhi == "巳" && (BaZi.nDiZhi == "申" || BaZi.nDiZhi == "酉" || BaZi.nDiZhi == "丑"))
        {
            XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
        }

        else if (BaZi.yDiZhi == "午" && (BaZi.nDiZhi == "未" || BaZi.nDiZhi == "寅" || BaZi.nDiZhi == "戌"))
        {
            XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
        }
        else if (BaZi.yDiZhi == "未" && (BaZi.nDiZhi == "午" || BaZi.nDiZhi == "亥" || BaZi.nDiZhi == "卯"))
        {
            XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
        }
        else if (BaZi.yDiZhi == "申" && (BaZi.nDiZhi == "巳" || BaZi.nDiZhi == "子" || BaZi.nDiZhi == "辰"))
        {
            XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
        }
        else if (BaZi.yDiZhi == "酉" && (BaZi.nDiZhi == "辰" || BaZi.nDiZhi == "巳" || BaZi.nDiZhi == "丑"))
        {
            XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
        }

        else if (BaZi.yDiZhi == "戌" && (BaZi.nDiZhi == "卯" || BaZi.nDiZhi == "寅" || BaZi.nDiZhi == "午"))
        {
            XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
        }
        else if (BaZi.yDiZhi == "亥" && (BaZi.nDiZhi == "寅" || BaZi.nDiZhi == "卯" || BaZi.nDiZhi == "未"))
        {
            XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
        }
        else
        {
            XWduanyu = "命中没有玄武桃花" + " 你对于另一半的年龄有着严格的要求。脸上皱纹更多的老帮菜显然是不入你法眼的。";
        }
    }

    //秋叶桃花
    public void GetQiuYeTaoHua()
    {
        #region 男
        if (sex == "男")
        {
            if (ShiShen.re1 == "正财")
            {
                tiangan = BaZi.rTianGan;
            }
            else if (ShiShen.re2 == "正财")
            {
                tiangan = BaZi.yTianGan;
            }
            else if (ShiShen.re3 == "正财")
            {
                tiangan = BaZi.sTianGan;
            }
            else if (ShiShen.re4 == "正财")
            {
                tiangan = ZangGan.nzhanggan[0];
            }
            else if (ShiShen.re5 == "正财")
            {
                tiangan = ZangGan.nzhanggan[1];
            }
            else if (ShiShen.re6 == "正财")
            {
                tiangan = ZangGan.nzhanggan[2];
            }
            else if (ShiShen.re7 == "正财")
            {
                tiangan = ZangGan.yzhanggan[0];
            }
            else if (ShiShen.re8 == "正财")
            {
                tiangan = ZangGan.yzhanggan[1];
            }
            else if (ShiShen.re9 == "正财")
            {
                tiangan = ZangGan.yzhanggan[2];
            }
            else if (ShiShen.re10 == "正财")
            {
                tiangan = ZangGan.rzhanggan[0];
            }
            else if (ShiShen.re11 == "正财")
            {
                tiangan = ZangGan.rzhanggan[1];
            }
            else if (ShiShen.re12 == "正财")
            {
                tiangan = ZangGan.rzhanggan[2];
            }
            else if (ShiShen.re13 == "正财")
            {
                tiangan = ZangGan.szhanggan[0];
            }
            else if (ShiShen.re14 == "正财")
            {
                tiangan = ZangGan.szhanggan[1];
            }
            else if (ShiShen.re15 == "正财")
            {
                tiangan = ZangGan.szhanggan[2];
            }
        }
        #endregion
        #region 女
        else
        {
            if (ShiShen.re1 == "正官")
            {
                tiangan = BaZi.rTianGan;
            }
            else if (ShiShen.re2 == "正官")
            {
                tiangan = BaZi.yTianGan;
            }
            else if (ShiShen.re3 == "正官")
            {
                tiangan = BaZi.sTianGan;
            }
            else if (ShiShen.re4 == "正官")
            {
                tiangan = ZangGan.nzhanggan[0];
            }
            else if (ShiShen.re5 == "正官")
            {
                tiangan = ZangGan.nzhanggan[1];
            }
            else if (ShiShen.re6 == "正官")
            {
                tiangan = ZangGan.nzhanggan[2];
            }
            else if (ShiShen.re7 == "正官")
            {
                tiangan = ZangGan.yzhanggan[0];
            }
            else if (ShiShen.re8 == "正官")
            {
                tiangan = ZangGan.yzhanggan[1];
            }
            else if (ShiShen.re9 == "正官")
            {
                tiangan = ZangGan.yzhanggan[2];
            }
            else if (ShiShen.re10 == "正官")
            {
                tiangan = ZangGan.rzhanggan[0];
            }
            else if (ShiShen.re11 == "正官")
            {
                tiangan = ZangGan.rzhanggan[1];
            }
            else if (ShiShen.re12 == "正官")
            {
                tiangan = ZangGan.rzhanggan[2];
            }
            else if (ShiShen.re13 == "正官")
            {
                tiangan = ZangGan.szhanggan[0];
            }
            else if (ShiShen.re14 == "正官")
            {
                tiangan = ZangGan.szhanggan[1];
            }
            else if (ShiShen.re15 == "正官")
            {
                tiangan = ZangGan.szhanggan[2];
            }
        }
        #endregion


        //去长生十二神表中拿天干和时支查询，得到结果

    }

    //八专桃花
    public void GetBaZhuanTaoHua()
    {
        if (BaZi.rizhu == "甲寅" || BaZi.rizhu == "乙卯" || BaZi.rizhu == "戊戌" || BaZi.rizhu == "己未" || BaZi.rizhu == "丁未" || BaZi.rizhu == "庚申" || BaZi.rizhu == "辛酉" || BaZi.rizhu == "癸丑")
        {
            BZduanyu = "命中有1朵八专桃花" + " 当分手的日子终于来到的时候，你会选择固执地藕断丝连。你难以忘却一起经历过的一切，当那些经历浇筑在你的记忆中后，分手对你而言格外的痛苦。";
        }
        else
        {
            BZduanyu = "命中没有八专桃花" + " 你不会执着于某一段情,当一段感情结束，即便是曾经刻骨铭心的记忆，你也会让往事随着时间流逝，而云淡风轻，轻松地收拾心情继续投入人生旅程。";
        }
    }

    //石榴桃花
    public void GetShiLiuTaoHua()
    {

        if (BaZi.sDiZhi == "子" && (BaZi.rDiZhi == "丑" || BaZi.rDiZhi == "申" || BaZi.rDiZhi == "辰"))
        {
            SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
        }

        else if (BaZi.sDiZhi == "丑" && (BaZi.rDiZhi == "子" || BaZi.rDiZhi == "巳" || BaZi.rDiZhi == "酉"))
        {
            SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
        }

        else if (BaZi.sDiZhi == "寅" && (BaZi.rDiZhi == "亥" || BaZi.rDiZhi == "午" || BaZi.rDiZhi == "戌"))
        {
            SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
        }

        else if (BaZi.yDiZhi == "卯" && (BaZi.rDiZhi == "戌" || BaZi.rDiZhi == "亥" || BaZi.rDiZhi == "未"))
        {
            SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
        }

        else if (BaZi.sDiZhi == "辰" && (BaZi.rDiZhi == "酉" || BaZi.rDiZhi == "申" || BaZi.rDiZhi == "子"))
        {
            SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
        }

        else if (BaZi.yDiZhi == "巳" && (BaZi.rDiZhi == "申" || BaZi.rDiZhi == "酉" || BaZi.rDiZhi == "丑"))
        {
            SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
        }

        else if (BaZi.sDiZhi == "午" && (BaZi.rDiZhi == "未" || BaZi.rDiZhi == "寅" || BaZi.rDiZhi == "戌"))
        {
            SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
        }
        else if (BaZi.sDiZhi == "未" && (BaZi.rDiZhi == "午" || BaZi.rDiZhi == "亥" || BaZi.rDiZhi == "卯"))
        {
            SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
        }
        else if (BaZi.sDiZhi == "申" && (BaZi.rDiZhi == "巳" || BaZi.rDiZhi == "子" || BaZi.rDiZhi == "辰"))
        {
            SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
        }
        else if (BaZi.sDiZhi == "酉" && (BaZi.rDiZhi == "辰" || BaZi.rDiZhi == "巳" || BaZi.rDiZhi == "丑"))
        {
            SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
        }
        else if (BaZi.sDiZhi == "戌" && (BaZi.rDiZhi == "卯" || BaZi.rDiZhi == "寅" || BaZi.rDiZhi == "午"))
        {
            SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
        }
        else if (BaZi.sDiZhi == "亥" && (BaZi.rDiZhi == "寅" || BaZi.rDiZhi == "卯" || BaZi.rDiZhi == "未"))
        {
            SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
        }
        else
        {
            SLduanyu = "命中没有石榴桃花" + " 奉子成婚的情况在你身上不大容易出现。而与对方长辈的相处中，你需要更加积极的交流策略来为自己加分。";
        }
    }
}