namespace Algorithm
{
    /// <summary>
    /// Taohua 的摘要说明
    /// </summary>

    public class Taohua
    {
        #region Old

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
        #endregion

        #region Fields & properties

        private BirthdateInfo _birthdate;

        private Bazi _bazi;

        #endregion

        #region Constructors

        public Taohua(Bazi bazi)
        {
            _bazi = bazi;
        }

        #endregion

        #region 算法

        /// <summary>
        ///  获取桃花预言
        /// </summary>
        /// <param name="type"></param>
        public string GetTaohuaPrediction(TaohuaType type)
        {
            switch (type)
            {
                case TaohuaType.咸池桃花:
                    break;
                case TaohuaType.红艳桃花:
                    break;
                case TaohuaType.插枝桃花:
                    break;
                case TaohuaType.遍野桃花:
                    break;
                case TaohuaType.裸体桃花:
                    break;
                case TaohuaType.六合桃花:
                    break;
                case TaohuaType.九丑桃花:
                    break;
                case TaohuaType.嫩芽桃花:
                    break;
                case TaohuaType.玄武桃花:
                    break;
                case TaohuaType.秋叶桃花:
                    break;
                case TaohuaType.八专桃花:
                    break;
                case TaohuaType.石榴桃花:
                    break;
            }

        }

        private string XianchiTaohua()
        {
            var count = 0;
            string yearZhi = _bazi.YearDizhi, monthZhi = _bazi.MonthDizhi, timeZhi = _bazi.TimeDizhi;

            switch (_bazi.DayDizhi)
            {
                case "寅":
                case "午":
                case "戌":
                    if (yearZhi == "卯") count++;
                    if (monthZhi == "卯") count++;
                    if (timeZhi == "卯") count++;
                    break;
                case "申":
                case "子":
                case "辰":
                    if (yearZhi == "酉") count++;
                    if (monthZhi == "酉") count++;
                    if (timeZhi == "酉") count++;
                    break;
                case "亥":
                case "卯":
                case "未":
                    if (yearZhi == "子") count++;
                    if (monthZhi == "子") count++;
                    if (timeZhi == "子") count++;
                    break;
                case "巳":
                case "酉":
                case "丑":
                    if (yearZhi == "午") count++;
                    if (monthZhi == "午") count++;
                    if (timeZhi == "午") count++;
                    break;
            }
        }

        #endregion


        #region Old Methods

        //咸池桃花
        public void GetXianChiTaoHua()
        {
            count = 0;
            if (Bazi.rDiZhi == "寅" && (Bazi.nDiZhi == "卯" || Bazi.yDiZhi == "卯" || Bazi.sDiZhi == "卯"))
            {
                if (Bazi.nDiZhi == "卯")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "卯")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "卯")
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


            else if (Bazi.rDiZhi == "午" && (Bazi.nDiZhi == "卯" || Bazi.yDiZhi == "卯" || Bazi.sDiZhi == "卯"))
            {
                count = 0;
                if (Bazi.nDiZhi == "卯")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "卯")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "卯")
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


            else if (Bazi.rDiZhi == "戌" && (Bazi.nDiZhi == "卯" || Bazi.yDiZhi == "卯" || Bazi.sDiZhi == "卯"))
            {
                count = 0;
                if (Bazi.nDiZhi == "卯")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "卯")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "卯")
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

            else if (Bazi.rDiZhi == "申" && (Bazi.nDiZhi == "酉" || Bazi.yDiZhi == "酉" || Bazi.sDiZhi == "酉"))
            {
                count = 0;
                if (Bazi.nDiZhi == "酉")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "酉")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "酉")
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

            else if (Bazi.rDiZhi == "子" && (Bazi.nDiZhi == "酉" || Bazi.yDiZhi == "酉" || Bazi.sDiZhi == "酉"))
            {
                count = 0;
                if (Bazi.nDiZhi == "酉")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "酉")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "酉")
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

            else if (Bazi.rDiZhi == "辰" && (Bazi.nDiZhi == "酉" || Bazi.yDiZhi == "酉" || Bazi.sDiZhi == "酉"))
            {
                count = 0;
                if (Bazi.nDiZhi == "酉")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "酉")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "酉")
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


            else if (Bazi.rDiZhi == "亥" && (Bazi.nDiZhi == "子" || Bazi.yDiZhi == "子" || Bazi.sDiZhi == "子"))
            {
                count = 0;
                if (Bazi.nDiZhi == "子")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "子")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "子")
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

            else if (Bazi.rDiZhi == "卯" && (Bazi.nDiZhi == "子" || Bazi.yDiZhi == "子" || Bazi.sDiZhi == "子"))
            {
                count = 0;
                if (Bazi.nDiZhi == "子")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "子")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "子")
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

            else if (Bazi.rDiZhi == "未" && (Bazi.nDiZhi == "子" || Bazi.yDiZhi == "子" || Bazi.sDiZhi == "子"))
            {
                count = 0;
                if (Bazi.nDiZhi == "子")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "子")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "子")
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

            else if (Bazi.rDiZhi == "巳" && (Bazi.nDiZhi == "午" || Bazi.yDiZhi == "午" || Bazi.sDiZhi == "午"))
            {
                count = 0;
                if (Bazi.nDiZhi == "午")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "午")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "午")
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

            else if (Bazi.rDiZhi == "酉" && (Bazi.nDiZhi == "午" || Bazi.yDiZhi == "午" || Bazi.sDiZhi == "午"))
            {
                count = 0;
                if (Bazi.nDiZhi == "午")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "午")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "午")
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

            else if (Bazi.rDiZhi == "丑" && (Bazi.nDiZhi == "午" || Bazi.yDiZhi == "午" || Bazi.sDiZhi == "午"))
            {
                count = 0;
                if (Bazi.nDiZhi == "午")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "午")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "午")
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
            if ((Bazi.nTianGan == "甲" || Bazi.rTianGan == "甲") && (Bazi.nDiZhi == "午" || Bazi.yDiZhi == "午" || Bazi.rDiZhi == "午" || Bazi.sDiZhi == "午"))
            {
                if (Bazi.nDiZhi == "午")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "午")
                {
                    count++;
                }
                if (Bazi.rDiZhi == "午")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "午")
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


            else if ((Bazi.nTianGan == "乙" || Bazi.rTianGan == "乙") && (Bazi.nDiZhi == "午" || Bazi.yDiZhi == "午" || Bazi.rDiZhi == "午" || Bazi.sDiZhi == "午"))
            {
                count = 0;
                if (Bazi.nDiZhi == "午")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "午")
                {
                    count++;
                }
                if (Bazi.rDiZhi == "午")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "午")
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


            else if ((Bazi.nTianGan == "丙" || Bazi.rTianGan == "丙") && (Bazi.nDiZhi == "寅" || Bazi.yDiZhi == "寅" || Bazi.rDiZhi == "寅" || Bazi.sDiZhi == "寅"))
            {
                count = 0;
                if (Bazi.nDiZhi == "寅")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "寅")
                {
                    count++;
                }
                if (Bazi.rDiZhi == "寅")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "寅")
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


            else if ((Bazi.nTianGan == "丁" || Bazi.rTianGan == "丁") && (Bazi.nDiZhi == "未" || Bazi.yDiZhi == "未" || Bazi.rDiZhi == "未" || Bazi.sDiZhi == "未"))
            {
                count = 0;
                if (Bazi.nDiZhi == "未")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "未")
                {
                    count++;
                }
                if (Bazi.rDiZhi == "未")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "未")
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


            else if ((Bazi.nTianGan == "戊" || Bazi.rTianGan == "戊") && (Bazi.nDiZhi == "辰" || Bazi.yDiZhi == "辰" || Bazi.rDiZhi == "辰" || Bazi.sDiZhi == "辰"))
            {
                count = 0;
                if (Bazi.nDiZhi == "辰")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "辰")
                {
                    count++;
                }
                if (Bazi.rDiZhi == "辰")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "辰")
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


            else if ((Bazi.nTianGan == "己" || Bazi.rTianGan == "己") && (Bazi.nDiZhi == "辰" || Bazi.yDiZhi == "辰" || Bazi.rDiZhi == "辰" || Bazi.sDiZhi == "辰"))
            {
                count = 0;
                if (Bazi.nDiZhi == "辰")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "辰")
                {
                    count++;
                }
                if (Bazi.rDiZhi == "辰")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "辰")
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


            else if ((Bazi.nTianGan == "庚" || Bazi.rTianGan == "庚") && (Bazi.nDiZhi == "戌" || Bazi.yDiZhi == "戌" || Bazi.rDiZhi == "戌" || Bazi.sDiZhi == "戌"))
            {
                count = 0;
                if (Bazi.nDiZhi == "戌")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "戌")
                {
                    count++;
                }
                if (Bazi.rDiZhi == "戌")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "戌")
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



            else if ((Bazi.nTianGan == "辛" || Bazi.rTianGan == "辛") && (Bazi.nDiZhi == "酉" || Bazi.yDiZhi == "酉" || Bazi.rDiZhi == "酉" || Bazi.sDiZhi == "酉"))
            {
                count = 0;
                if (Bazi.nDiZhi == "酉")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "酉")
                {
                    count++;
                }
                if (Bazi.rDiZhi == "酉")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "酉")
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


            else if ((Bazi.nTianGan == "壬" || Bazi.rTianGan == "壬") && (Bazi.nDiZhi == "子" || Bazi.yDiZhi == "子" || Bazi.rDiZhi == "子" || Bazi.sDiZhi == "子"))
            {
                count = 0;
                if (Bazi.nDiZhi == "子")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "子")
                {
                    count++;
                }
                if (Bazi.rDiZhi == "子")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "子")
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



            else if ((Bazi.nTianGan == "癸" || Bazi.rTianGan == "癸") && (Bazi.nDiZhi == "丑" || Bazi.yDiZhi == "丑" || Bazi.rDiZhi == "丑" || Bazi.sDiZhi == "丑"))
            {
                count = 0;
                if (Bazi.nDiZhi == "丑")
                {
                    count++;
                }
                if (Bazi.yDiZhi == "丑")
                {
                    count++;
                }
                if (Bazi.rDiZhi == "丑")
                {
                    count++;
                }
                if (Bazi.sDiZhi == "丑")
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
            if (Bazi.yDiZhi == "子" && (Bazi.rDiZhi == "申" || Bazi.rDiZhi == "辰"))
            {
                CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
            }
            else if (Bazi.yDiZhi == "丑" && (Bazi.rDiZhi == "巳" || Bazi.rDiZhi == "酉"))
            {
                CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
            }
            else if (Bazi.yDiZhi == "寅" && (Bazi.rDiZhi == "午" || Bazi.rDiZhi == "戌"))
            {
                CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
            }
            else if (Bazi.yDiZhi == "卯" && (Bazi.rDiZhi == "亥" || Bazi.rDiZhi == "未"))
            {
                CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
            }
            else if (Bazi.yDiZhi == "辰" && (Bazi.rDiZhi == "申" || Bazi.rDiZhi == "子"))
            {
                CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
            }
            else if (Bazi.yDiZhi == "巳" && (Bazi.rDiZhi == "酉" || Bazi.rDiZhi == "丑"))
            {
                CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
            }
            else if (Bazi.yDiZhi == "午" && (Bazi.rDiZhi == "寅" || Bazi.rDiZhi == "戌"))
            {
                CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
            }
            else if (Bazi.yDiZhi == "未" && (Bazi.rDiZhi == "亥" || Bazi.rDiZhi == "卯"))
            {
                CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
            }
            else if (Bazi.yDiZhi == "申" && (Bazi.rDiZhi == "子" || Bazi.rDiZhi == "辰"))
            {
                CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
            }
            else if (Bazi.yDiZhi == "酉" && (Bazi.rDiZhi == "巳" || Bazi.rDiZhi == "丑"))
            {
                CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
            }
            else if (Bazi.yDiZhi == "戌" && (Bazi.rDiZhi == "寅" || Bazi.rDiZhi == "午"))
            {
                CZduanyu = "命中有1朵插枝桃花" + " 即使没有耀眼的外表和出尘的气质，你的身上也不缺乏令人着迷的东西。低调可靠地行事、一语中的地评论就足够让你拥有神秘的魅力。一个无心插柳的决定，或许就会让你赢得异性的倾慕。";
            }
            else if (Bazi.yDiZhi == "亥" && (Bazi.rDiZhi == "卯" || Bazi.rDiZhi == "未"))
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
            if (Bazi.nDiZhi == "子" || Bazi.nDiZhi == " 午" || Bazi.nDiZhi == " 卯" || Bazi.nDiZhi == " 酉")
            {
                count++;
            }
            if (Bazi.yDiZhi == "子" || Bazi.yDiZhi == " 午" || Bazi.yDiZhi == " 卯" || Bazi.yDiZhi == " 酉")
            {
                count++;
            }
            if (Bazi.rDiZhi == "子" || Bazi.rDiZhi == " 午" || Bazi.rDiZhi == " 卯" || Bazi.rDiZhi == " 酉")
            {
                count++;
            }
            if (Bazi.sDiZhi == "子" || Bazi.sDiZhi == " 午" || Bazi.sDiZhi == " 卯" || Bazi.sDiZhi == " 酉")
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
            if (Bazi.rizhu == "甲子" || Bazi.rizhu == "丁卯" || Bazi.rizhu == "庚午" || Bazi.rizhu == "癸酉")
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
            if (Bazi.rTianGan == "甲" && (Canggan.yz.Contains("巳") || Canggan.rz.Contains("巳") || Canggan.sz.Contains("巳")))
            {
                if (Canggan.yzhanggan[0] == "巳" || Canggan.yzhanggan[1] == "巳" || Canggan.yzhanggan[2] == "巳")
                {
                    count++;
                }
                else if (Canggan.rzhanggan[0] == "巳" || Canggan.rzhanggan[1] == "巳" || Canggan.rzhanggan[2] == "巳")
                {
                    count++;
                }
                else if (Canggan.szhanggan[0] == "巳" || Canggan.szhanggan[1] == "巳" || Canggan.szhanggan[2] == "巳")
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

            if (Bazi.rTianGan == "乙" && (Canggan.yz.Contains("庚") || Canggan.rz.Contains("庚") || Canggan.sz.Contains("庚")))
            {
                if (Canggan.yzhanggan[0] == "庚" || Canggan.yzhanggan[1] == "庚" || Canggan.yzhanggan[2] == "庚")
                {
                    count++;
                }
                else if (Canggan.rzhanggan[0] == "庚" || Canggan.rzhanggan[1] == "庚" || Canggan.rzhanggan[2] == "庚")
                {
                    count++;
                }
                else if (Canggan.szhanggan[0] == "庚" || Canggan.szhanggan[1] == "庚" || Canggan.szhanggan[2] == "庚")
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

            if (Bazi.rTianGan == "丙" && (Canggan.yz.Contains("辛") || Canggan.rz.Contains("辛") || Canggan.sz.Contains("辛")))
            {
                if (Canggan.yzhanggan[0] == "辛" || Canggan.yzhanggan[1] == "辛" || Canggan.yzhanggan[2] == "辛")
                {
                    count++;
                }
                else if (Canggan.rzhanggan[0] == "辛" || Canggan.rzhanggan[1] == "辛" || Canggan.rzhanggan[2] == "辛")
                {
                    count++;
                }
                else if (Canggan.szhanggan[0] == "辛" || Canggan.szhanggan[1] == "辛" || Canggan.szhanggan[2] == "辛")
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

            if (Bazi.rTianGan == "丁" && (Canggan.yz.Contains("壬") || Canggan.rz.Contains("壬") || Canggan.sz.Contains("壬")))
            {
                if (Canggan.yzhanggan[0] == "壬" || Canggan.yzhanggan[1] == "壬" || Canggan.yzhanggan[2] == "壬")
                {
                    count++;
                }
                else if (Canggan.rzhanggan[0] == "壬" || Canggan.rzhanggan[1] == "壬" || Canggan.rzhanggan[2] == "壬")
                {
                    count++;
                }
                else if (Canggan.szhanggan[0] == "壬" || Canggan.szhanggan[1] == "壬" || Canggan.szhanggan[2] == "壬")
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

            if (Bazi.rTianGan == "戊" && (Canggan.yz.Contains("癸") || Canggan.rz.Contains("癸") || Canggan.sz.Contains("癸")))
            {
                if (Canggan.yzhanggan[0] == "癸" || Canggan.yzhanggan[1] == "癸" || Canggan.yzhanggan[2] == "癸")
                {
                    count++;
                }
                else if (Canggan.rzhanggan[0] == "癸" || Canggan.rzhanggan[1] == "癸" || Canggan.rzhanggan[2] == "癸")
                {
                    count++;
                }
                else if (Canggan.szhanggan[0] == "癸" || Canggan.szhanggan[1] == "癸" || Canggan.szhanggan[2] == "癸")
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
            if (Bazi.rTianGan == "己" && (Canggan.yz.Contains("甲") || Canggan.rz.Contains("甲") || Canggan.sz.Contains("甲")))
            {
                if (Canggan.yzhanggan[0] == "甲" || Canggan.yzhanggan[1] == "甲" || Canggan.yzhanggan[2] == "甲")
                {
                    count++;
                }
                else if (Canggan.rzhanggan[0] == "甲" || Canggan.rzhanggan[1] == "甲" || Canggan.rzhanggan[2] == "甲")
                {
                    count++;
                }
                else if (Canggan.szhanggan[0] == "甲" || Canggan.szhanggan[1] == "甲" || Canggan.szhanggan[2] == "甲")
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

            if (Bazi.rTianGan == "庚" && (Canggan.yz.Contains("乙") || Canggan.rz.Contains("乙") || Canggan.sz.Contains("乙")))
            {
                if (Canggan.yzhanggan[0] == "乙" || Canggan.yzhanggan[1] == "乙" || Canggan.yzhanggan[2] == "乙")
                {
                    count++;
                }
                else if (Canggan.rzhanggan[0] == "乙" || Canggan.rzhanggan[1] == "乙" || Canggan.rzhanggan[2] == "乙")
                {
                    count++;
                }
                else if (Canggan.szhanggan[0] == "乙" || Canggan.szhanggan[1] == "乙" || Canggan.szhanggan[2] == "乙")
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

            if (Bazi.rTianGan == "辛" && (Canggan.yz.Contains("丙") || Canggan.rz.Contains("丙") || Canggan.sz.Contains("丙")))
            {
                if (Canggan.yzhanggan[0] == "丙" || Canggan.yzhanggan[1] == "丙" || Canggan.yzhanggan[2] == "丙")
                {
                    count++;
                }
                else if (Canggan.rzhanggan[0] == "丙" || Canggan.rzhanggan[1] == "丙" || Canggan.rzhanggan[2] == "丙")
                {
                    count++;
                }
                else if (Canggan.szhanggan[0] == "丙" || Canggan.szhanggan[1] == "丙" || Canggan.szhanggan[2] == "丙")
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

            if (Bazi.rTianGan == "壬" && (Canggan.yz.Contains("丁") || Canggan.rz.Contains("丁") || Canggan.sz.Contains("丁")))
            {
                if (Canggan.yzhanggan[0] == "丁" || Canggan.yzhanggan[1] == "丁" || Canggan.yzhanggan[2] == "丁")
                {
                    count++;
                }
                else if (Canggan.rzhanggan[0] == "丁" || Canggan.rzhanggan[1] == "丁" || Canggan.rzhanggan[2] == "丁")
                {
                    count++;
                }
                else if (Canggan.szhanggan[0] == "丁" || Canggan.szhanggan[1] == "丁" || Canggan.szhanggan[2] == "丁")
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

            if (Bazi.rTianGan == "癸" && (Canggan.yz.Contains("戊") || Canggan.rz.Contains("戊") || Canggan.sz.Contains("戊")))
            {
                if (Canggan.yzhanggan[0] == "戊" || Canggan.yzhanggan[1] == "戊" || Canggan.yzhanggan[2] == "戊")
                {
                    count++;
                }
                else if (Canggan.rzhanggan[0] == "戊" || Canggan.rzhanggan[1] == "戊" || Canggan.rzhanggan[2] == "戊")
                {
                    count++;
                }
                else if (Canggan.szhanggan[0] == "戊" || Canggan.szhanggan[1] == "戊" || Canggan.szhanggan[2] == "戊")
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

            if (Bazi.rizhu == "丁酉" || Bazi.rizhu == "戊子" || Bazi.rizhu == "戊午" || Bazi.rizhu == "己卯" || Bazi.rizhu == "己酉" || Bazi.rizhu == "辛卯" || Bazi.rizhu == "辛酉" || Bazi.rizhu == "壬子" || Bazi.rizhu == "壬午")
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
            if (Bazi.yDiZhi == "子" && (Bazi.sDiZhi == "丑" || Bazi.sDiZhi == "申" || Bazi.sDiZhi == "辰"))
            {
                NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
            }
            else if (Bazi.yDiZhi == "丑" && (Bazi.sDiZhi == "子" || Bazi.sDiZhi == "巳" || Bazi.sDiZhi == "酉"))
            {
                NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
            }
            else if (Bazi.yDiZhi == "寅" && (Bazi.sDiZhi == "亥" || Bazi.sDiZhi == "午" || Bazi.sDiZhi == "戌"))
            {
                NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
            }
            else if (Bazi.yDiZhi == "卯" && (Bazi.sDiZhi == "戌" || Bazi.sDiZhi == "亥" || Bazi.sDiZhi == "未"))
            {
                NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
            }
            else if (Bazi.yDiZhi == "辰" && (Bazi.sDiZhi == "酉" || Bazi.sDiZhi == "申" || Bazi.sDiZhi == "子"))
            {
                NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
            }
            else if (Bazi.yDiZhi == "巳" && (Bazi.sDiZhi == "申" || Bazi.sDiZhi == "酉" || Bazi.sDiZhi == "丑"))
            {
                NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
            }
            else if (Bazi.yDiZhi == "午" && (Bazi.sDiZhi == "未" || Bazi.sDiZhi == "寅" || Bazi.sDiZhi == "戌"))
            {
                NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
            }
            else if (Bazi.yDiZhi == "未" && (Bazi.sDiZhi == "午" || Bazi.sDiZhi == "亥" || Bazi.sDiZhi == "卯"))
            {
                NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
            }
            else if (Bazi.yDiZhi == "申" && (Bazi.sDiZhi == "巳" || Bazi.sDiZhi == "子" || Bazi.sDiZhi == "辰"))
            {
                NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
            }
            else if (Bazi.yDiZhi == "酉" && (Bazi.sDiZhi == "辰" || Bazi.sDiZhi == "巳" || Bazi.sDiZhi == "丑"))
            {
                NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
            }
            else if (Bazi.yDiZhi == "戌" && (Bazi.sDiZhi == "卯" || Bazi.sDiZhi == "寅" || Bazi.sDiZhi == "午"))
            {
                NYduanyu = "命中有1朵嫩芽桃花" + " 你的另一半很有可能要比你年轻许多，更加成熟和体贴的你在魅力方面显然加分不少。";
            }
            else if (Bazi.yDiZhi == "亥" && (Bazi.sDiZhi == "寅" || Bazi.sDiZhi == "卯" || Bazi.sDiZhi == "未"))
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
            if (Bazi.yDiZhi == "子" && (Bazi.nDiZhi == "丑" || Bazi.nDiZhi == "申" || Bazi.nDiZhi == "辰"))
            {
                XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
            }

            else if (Bazi.yDiZhi == "丑" && (Bazi.nDiZhi == "子" || Bazi.nDiZhi == "巳" || Bazi.nDiZhi == "酉"))
            {
                XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
            }

            else if (Bazi.yDiZhi == "寅" && (Bazi.nDiZhi == "亥" || Bazi.nDiZhi == "午" || Bazi.nDiZhi == "戌"))
            {
                XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
            }

            else if (Bazi.yDiZhi == "卯" && (Bazi.nDiZhi == "戌" || Bazi.nDiZhi == "亥" || Bazi.nDiZhi == "未"))
            {
                XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
            }

            else if (Bazi.yDiZhi == "辰" && (Bazi.nDiZhi == "酉" || Bazi.nDiZhi == "申" || Bazi.nDiZhi == "子"))
            {
                XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
            }

            else if (Bazi.yDiZhi == "巳" && (Bazi.nDiZhi == "申" || Bazi.nDiZhi == "酉" || Bazi.nDiZhi == "丑"))
            {
                XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
            }

            else if (Bazi.yDiZhi == "午" && (Bazi.nDiZhi == "未" || Bazi.nDiZhi == "寅" || Bazi.nDiZhi == "戌"))
            {
                XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
            }
            else if (Bazi.yDiZhi == "未" && (Bazi.nDiZhi == "午" || Bazi.nDiZhi == "亥" || Bazi.nDiZhi == "卯"))
            {
                XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
            }
            else if (Bazi.yDiZhi == "申" && (Bazi.nDiZhi == "巳" || Bazi.nDiZhi == "子" || Bazi.nDiZhi == "辰"))
            {
                XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
            }
            else if (Bazi.yDiZhi == "酉" && (Bazi.nDiZhi == "辰" || Bazi.nDiZhi == "巳" || Bazi.nDiZhi == "丑"))
            {
                XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
            }

            else if (Bazi.yDiZhi == "戌" && (Bazi.nDiZhi == "卯" || Bazi.nDiZhi == "寅" || Bazi.nDiZhi == "午"))
            {
                XWduanyu = "命中有1朵玄武桃花" + " 你的另一半也可能是一位比你年长不少的人。你对更加丰富的人生经验有着强烈的好奇，更加成熟老练的性格同样也吸引着你。";
            }
            else if (Bazi.yDiZhi == "亥" && (Bazi.nDiZhi == "寅" || Bazi.nDiZhi == "卯" || Bazi.nDiZhi == "未"))
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
                if (Shishen.re1 == "正财")
                {
                    tiangan = Bazi.rTianGan;
                }
                else if (Shishen.re2 == "正财")
                {
                    tiangan = Bazi.yTianGan;
                }
                else if (Shishen.re3 == "正财")
                {
                    tiangan = Bazi.sTianGan;
                }
                else if (Shishen.re4 == "正财")
                {
                    tiangan = Canggan.nzhanggan[0];
                }
                else if (Shishen.re5 == "正财")
                {
                    tiangan = Canggan.nzhanggan[1];
                }
                else if (Shishen.re6 == "正财")
                {
                    tiangan = Canggan.nzhanggan[2];
                }
                else if (Shishen.re7 == "正财")
                {
                    tiangan = Canggan.yzhanggan[0];
                }
                else if (Shishen.re8 == "正财")
                {
                    tiangan = Canggan.yzhanggan[1];
                }
                else if (Shishen.re9 == "正财")
                {
                    tiangan = Canggan.yzhanggan[2];
                }
                else if (Shishen.re10 == "正财")
                {
                    tiangan = Canggan.rzhanggan[0];
                }
                else if (Shishen.re11 == "正财")
                {
                    tiangan = Canggan.rzhanggan[1];
                }
                else if (Shishen.re12 == "正财")
                {
                    tiangan = Canggan.rzhanggan[2];
                }
                else if (Shishen.re13 == "正财")
                {
                    tiangan = Canggan.szhanggan[0];
                }
                else if (Shishen.re14 == "正财")
                {
                    tiangan = Canggan.szhanggan[1];
                }
                else if (Shishen.re15 == "正财")
                {
                    tiangan = Canggan.szhanggan[2];
                }
            }
            #endregion
            #region 女
            else
            {
                if (Shishen.re1 == "正官")
                {
                    tiangan = Bazi.rTianGan;
                }
                else if (Shishen.re2 == "正官")
                {
                    tiangan = Bazi.yTianGan;
                }
                else if (Shishen.re3 == "正官")
                {
                    tiangan = Bazi.sTianGan;
                }
                else if (Shishen.re4 == "正官")
                {
                    tiangan = Canggan.nzhanggan[0];
                }
                else if (Shishen.re5 == "正官")
                {
                    tiangan = Canggan.nzhanggan[1];
                }
                else if (Shishen.re6 == "正官")
                {
                    tiangan = Canggan.nzhanggan[2];
                }
                else if (Shishen.re7 == "正官")
                {
                    tiangan = Canggan.yzhanggan[0];
                }
                else if (Shishen.re8 == "正官")
                {
                    tiangan = Canggan.yzhanggan[1];
                }
                else if (Shishen.re9 == "正官")
                {
                    tiangan = Canggan.yzhanggan[2];
                }
                else if (Shishen.re10 == "正官")
                {
                    tiangan = Canggan.rzhanggan[0];
                }
                else if (Shishen.re11 == "正官")
                {
                    tiangan = Canggan.rzhanggan[1];
                }
                else if (Shishen.re12 == "正官")
                {
                    tiangan = Canggan.rzhanggan[2];
                }
                else if (Shishen.re13 == "正官")
                {
                    tiangan = Canggan.szhanggan[0];
                }
                else if (Shishen.re14 == "正官")
                {
                    tiangan = Canggan.szhanggan[1];
                }
                else if (Shishen.re15 == "正官")
                {
                    tiangan = Canggan.szhanggan[2];
                }
            }
            #endregion


            //去长生十二神表中拿天干和时支查询，得到结果

        }

        //八专桃花
        public void GetBaZhuanTaoHua()
        {
            if (Bazi.rizhu == "甲寅" || Bazi.rizhu == "乙卯" || Bazi.rizhu == "戊戌" || Bazi.rizhu == "己未" || Bazi.rizhu == "丁未" || Bazi.rizhu == "庚申" || Bazi.rizhu == "辛酉" || Bazi.rizhu == "癸丑")
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

            if (Bazi.sDiZhi == "子" && (Bazi.rDiZhi == "丑" || Bazi.rDiZhi == "申" || Bazi.rDiZhi == "辰"))
            {
                SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
            }

            else if (Bazi.sDiZhi == "丑" && (Bazi.rDiZhi == "子" || Bazi.rDiZhi == "巳" || Bazi.rDiZhi == "酉"))
            {
                SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
            }

            else if (Bazi.sDiZhi == "寅" && (Bazi.rDiZhi == "亥" || Bazi.rDiZhi == "午" || Bazi.rDiZhi == "戌"))
            {
                SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
            }

            else if (Bazi.yDiZhi == "卯" && (Bazi.rDiZhi == "戌" || Bazi.rDiZhi == "亥" || Bazi.rDiZhi == "未"))
            {
                SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
            }

            else if (Bazi.sDiZhi == "辰" && (Bazi.rDiZhi == "酉" || Bazi.rDiZhi == "申" || Bazi.rDiZhi == "子"))
            {
                SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
            }

            else if (Bazi.yDiZhi == "巳" && (Bazi.rDiZhi == "申" || Bazi.rDiZhi == "酉" || Bazi.rDiZhi == "丑"))
            {
                SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
            }

            else if (Bazi.sDiZhi == "午" && (Bazi.rDiZhi == "未" || Bazi.rDiZhi == "寅" || Bazi.rDiZhi == "戌"))
            {
                SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
            }
            else if (Bazi.sDiZhi == "未" && (Bazi.rDiZhi == "午" || Bazi.rDiZhi == "亥" || Bazi.rDiZhi == "卯"))
            {
                SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
            }
            else if (Bazi.sDiZhi == "申" && (Bazi.rDiZhi == "巳" || Bazi.rDiZhi == "子" || Bazi.rDiZhi == "辰"))
            {
                SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
            }
            else if (Bazi.sDiZhi == "酉" && (Bazi.rDiZhi == "辰" || Bazi.rDiZhi == "巳" || Bazi.rDiZhi == "丑"))
            {
                SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
            }
            else if (Bazi.sDiZhi == "戌" && (Bazi.rDiZhi == "卯" || Bazi.rDiZhi == "寅" || Bazi.rDiZhi == "午"))
            {
                SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
            }
            else if (Bazi.sDiZhi == "亥" && (Bazi.rDiZhi == "寅" || Bazi.rDiZhi == "卯" || Bazi.rDiZhi == "未"))
            {
                SLduanyu = "命中有1朵石榴桃花" + " 你奉子成婚的机率，比一般人高出许多哦！这或许可以帮你在长辈之中赢得不少好感。对于「以结婚当作交往前提」的人来说，命带石榴桃花，可算是一股不小的助力。";
            }
            else
            {
                SLduanyu = "命中没有石榴桃花" + " 奉子成婚的情况在你身上不大容易出现。而与对方长辈的相处中，你需要更加积极的交流策略来为自己加分。";
            }
        }

        #endregion

    }

    public enum TaohuaType
    {
        咸池桃花 = 1,
        红艳桃花 = 2,
        插枝桃花 = 3,
        遍野桃花 = 4,
        裸体桃花 = 5,
        六合桃花 = 6,
        九丑桃花 = 7,
        嫩芽桃花 = 8,
        玄武桃花 = 9,
        秋叶桃花 = 10,
        八专桃花 = 11,
        石榴桃花 = 12,
    }
}