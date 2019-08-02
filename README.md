# Loading Xamarin.Forms ListView inside ScrollView

When the `SfListView` is loaded inside the `ScrollView` with the height of total items, scrolling will not occur in the SfListView only when [AllowSwiping](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~AllowSwiping.html) is set to `true`. The SfListView does not pass touch to the parent ScrollView in UWP, because swiping is handled in it.

When the SfListView is loaded inside the ScrollView the following scenarios, the height of the total items is set to `HeightRequest` of the SfListView.

If the position of the SfListView is not in view when loading inside the StackLayout with more than one children, the SfListView will not be loaded. Because, the StackLayout passes the height for the `SfListView` as 1.

When loading the SfListView inside the `Grid` with row definition as `Auto` in UWP, Grid passes the height for the SfListView to be 1.

```
<local:ExtScrollView x:Name="scrollView" >
   <sync:SfListView x:Name="listView" ItemsSource="{Binding BookInfo}"/>
</local:ExtScrollView>
```
When the SfListView is loaded inside the ScrollView with sticky header and sticky group header, it changed to scrollable. The empty space remains after the SfListView items, when the device orientation is changed to horizontal. Because, the total extend is set to the `ScrollView` in horizontal orientation

```
public class ExtScrollView: ScrollView
{    
     protected override void LayoutChildren(double x, double y, double width, double height)
     {
         this.Content.HeightRequest = height;
         base.LayoutChildren(x, y, width, height);
     }
}
```

To know more about MVVM in ListView, please refer our documentation [here](https://help.syncfusion.com/xamarin/sflistview/mvvm)
