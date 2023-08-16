This article illustrates the process of integrating badges within a ListView in a .NET MAUI application.

**Step 1: Initialize the ListView with Grouping Property**

In .NET MAUI application, initialize the ListView with grouping enabled. Grouping categorizes items within the ListView.

**Step 2: Bind ListView to ViewModel Data Source**

Bind the `ItemsSource` property of the ListView to a collection named Items within the ViewModel. This collection serves as the data source for the ListView.

**Step 3: Initialize Badge View within DataTemplate**

Inside the DataTemplate of the ListView, initialize the [Badge View](https://www.syncfusion.com/maui-controls/maui-badge-view) control and set its BadgeText property.

**Step 4: Customize Badge Appearance**

The BadgeView showcases a badge displaying the `Count` property of each item. Customize the badge appearance using the [BadgeSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html#Syncfusion_Maui_Core_SfBadgeView_BadgeSettings) property.

**XAML**

```
    <ContentPage.BindingContext>
        <local:ViewModel></local:ViewModel>
    </ContentPage.BindingContext>
    <ListView ItemsSource="{Binding Items}"
              SelectionMode="Single"                   
              IsGroupingEnabled="True"
              CachingStrategy="RecycleElement"  
              RowHeight="50">
        <ListView.ItemTemplate>
            <DataTemplate>
                <ViewCell>
                    <Grid Margin="30,0,0,0">
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="*"/>
                            <ColumnDefinition Width="*"/>
                        </Grid.ColumnDefinitions>
                        <Label HorizontalOptions="Start" VerticalOptions="Center" 
                               Text="{Binding Category}"/>
                        <badgeview:SfBadgeView BadgeText="{Binding Count}"
                                               HorizontalOptions="End"
                                               VerticalOptions="Center">
                            <badgeview:SfBadgeView.BadgeSettings>
                                <badgeview:BadgeSettings Type="None" 
                                                         Background="{Binding Color}" 
                                                         TextColor="White" 
                                                         FontAttributes="Bold" 
                                                         CornerRadius="0" 
                                                         Position="TopRight" />
                            </badgeview:SfBadgeView.BadgeSettings>
                        </badgeview:SfBadgeView>
                    </Grid>
                </ViewCell>
            </DataTemplate>
        </ListView.ItemTemplate>
        <ListView.GroupHeaderTemplate>
            <DataTemplate>
                <ViewCell>
                    <Label Margin="10,10,0,0" 
                           FontSize="17" 
                           FontAttributes="Bold" 
                           Text="{Binding Heading}"/>
                </ViewCell>
            </DataTemplate>
        </ListView.GroupHeaderTemplate>
    </ListView>
```

**Output**

![Screenshot 2023-08-16 155932.jpg](https://support.bolddesk.com/kb/agent/attachment/article/13451/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEwMTM4Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5ib2xkZGVzay5jb20ifQ.5L0bQkyNkDl7HurP5mhoRo0xTqrSsWGWebSN2I5sqfE)
