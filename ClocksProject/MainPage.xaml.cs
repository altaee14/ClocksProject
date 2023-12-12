using System;

namespace ClocksProject;

public partial class MainPage : ContentPage
{
    private readonly Indicators _ind1 = new();
    private readonly Indicators _ind2 = new();
    private readonly Indicators _ind3 = new();
    private readonly Indicators _ind4 = new();

    public MainPage()
	{
		InitializeComponent();
        StartTimer();
    }

    private async void StartTimer()
    {
        var timer = new PeriodicTimer(TimeSpan.FromSeconds(1));

        while (await timer.WaitForNextTickAsync())
        {
            Segment0000.IsVisible = !Segment0000.IsVisible;
            Segment1111.IsVisible = !Segment1111.IsVisible;
            var givenTime = DateTime.Now;

            _ind1.ChangeSegmentsVisibilityByNumber(givenTime.Hour / 10);
            _ind2.ChangeSegmentsVisibilityByNumber(givenTime.Hour % 10);
            _ind3.ChangeSegmentsVisibilityByNumber(givenTime.Minute / 10);
            _ind4.ChangeSegmentsVisibilityByNumber(givenTime.Minute % 10);
            UpdateAllIndicators();
        }
    }
    private void UpdateAllIndicators()
    {
        _ind1.UpdateSegments(Segment10, Segment11, Segment12, Segment13, Segment14, Segment15, Segment16);
        _ind2.UpdateSegments(Segment20, Segment21, Segment22, Segment23, Segment24, Segment25, Segment26);
        _ind3.UpdateSegments(Segment30, Segment31, Segment32, Segment33, Segment34, Segment35, Segment36);
        _ind4.UpdateSegments(Segment40, Segment41, Segment42, Segment43, Segment44, Segment45, Segment46);
    }
}


