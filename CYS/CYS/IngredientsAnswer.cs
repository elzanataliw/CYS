using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYS
{
    class IngredientsAnswer
    {
        private bool isPregnant;

        private bool isUsingBHAetc;

        private bool isUsingRetinol;

        private List<string> targetCondition;

        private List<string> skinWishCondition;

        public bool IsPregnant { get => isPregnant; set => isPregnant = value; }
        public bool IsUsingBHAetc { get => isUsingBHAetc; set => isUsingBHAetc = value; }
        public bool IsUsingRetinol { get => isUsingRetinol; set => isUsingRetinol = value; }
        public List<string> TargetCondition { get => targetCondition; set => targetCondition = value; }
        public List<string> SkinWishCondition { get => skinWishCondition; set => skinWishCondition = value; }

        public IngredientsAnswer(bool isPregnant, bool isUsingBHAetc, bool isUsingRetinol, List<string> targetCondition, List<string> skinWishCondition)
        {
            IsPregnant = isPregnant;
            IsUsingBHAetc = isUsingBHAetc;
            IsUsingRetinol = isUsingRetinol;
            TargetCondition = targetCondition;
            SkinWishCondition = skinWishCondition;
        }
    }
}
