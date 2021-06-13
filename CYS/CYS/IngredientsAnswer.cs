using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYS
{
    public class IngredientsAnswer
    {
        private static bool isPregnant = false;

        private static bool isUsingBHAetc = false;

        private static bool isUsingRetinol = false;

        private static string targetCondition = null;

        private static string skinWishCondition1 = null;

        private static string skinWishCondition2 = null;

        public static bool IsPregnant { get => isPregnant; set => isPregnant = value; }
        public static bool IsUsingBHAetc { get => isUsingBHAetc; set => isUsingBHAetc = value; }
        public static bool IsUsingRetinol { get => isUsingRetinol; set => isUsingRetinol = value; }
        public static string TargetCondition { get => targetCondition; set => targetCondition = value; }
        public static string SkinWishCondition1 { get => skinWishCondition1; set => skinWishCondition1 = value;}
        public static string SkinWishCondition2 { get => skinWishCondition2; set => skinWishCondition2 = value; }

    }
}
