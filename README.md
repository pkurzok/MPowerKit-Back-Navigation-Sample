# MPowerKit Back Navigation Sample
Sample Project that demonstrates a Back Navigation Issue using swipe gestures

When opening a sub page and using a swipe gesture to go back, the next time navigating to the sub page fails with the following error:

```
System.InvalidOperationException: Cannot execute relative navigation from inactive page
   at MPowerKit.Navigation.NavigationService.DoRelativeNavigation(List`1 pages, INavigationParameters parameters, Boolean animated)
   at MPowerKit.Navigation.NavigationService.NavigateAsync(String stringUri, INavigationParameters parameters, Boolean modal, Boolean animated)
```

The issue only occurs on iOS. On Device but also on Simulator.
