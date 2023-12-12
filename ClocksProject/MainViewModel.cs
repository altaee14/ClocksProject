using ClocksProject;

namespace ClocksProject
{
    internal static class Visibles
    {
        public static void UpdateSegments(this Indicators indicators, BoxView topSegment, BoxView leftTopSegment,
            BoxView rightTopSegment, BoxView middleSegment, BoxView leftBottomSegment, BoxView rightBottomSegment, BoxView bottomSegment)
        {
            topSegment.IsVisible = indicators.TopSegment;
            leftTopSegment.IsVisible = indicators.LeftTopSegment;
            rightTopSegment.IsVisible = indicators.RightTopSegment;
            middleSegment.IsVisible = indicators.MiddleSegment;
            leftBottomSegment.IsVisible = indicators.LeftBottomSegment;
            rightBottomSegment.IsVisible = indicators.RightBottomSegment;
            bottomSegment.IsVisible = indicators.BottomSegment;
        }

    }

}