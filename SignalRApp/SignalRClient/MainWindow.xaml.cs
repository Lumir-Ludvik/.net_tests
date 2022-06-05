using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace SignalRClient;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    HubConnection hubConnection;
    private int userId = new Random().Next(0, 101);
    private bool isInGroup = false;
    public MainWindow()
    {
        InitializeComponent();

        userName.Content = $"WPF Client: {userId}";
        hubConnection = new HubConnectionBuilder()
            .WithUrl("https://localhost:7268/chathub")
            .WithAutomaticReconnect()
            .Build();

        hubConnection.Reconnecting += sender =>
        {
            Dispatcher.Invoke(() =>
            {
                var newMessage = "Attempting to reconnect...";
                messages.Items.Add(newMessage);
            });

            return Task.CompletedTask;
        };

        hubConnection.Reconnected += sender =>
        {
            Dispatcher.Invoke(() =>
            {
                var newMessage = "Reconnected to the server!";
                messages.Items.Clear();
                messages.Items.Add(newMessage);
                hubConnection.InvokeAsync("SendStatus", userName.Content, true);
            });

            return Task.CompletedTask;
        };

        hubConnection.Closed += sender =>
        {
            Dispatcher.Invoke(() =>
            {
                var newMessage = "Connection has been closed";
                messages.Items.Add(newMessage);
                openConnection.IsEnabled = true;
                sendMessage.IsEnabled = false;
                hubConnection.InvokeAsync("SendStatus", userName.Content, false);
            });

            return Task.CompletedTask;
        };
    }

    private async void openConnection_Click(object sender, RoutedEventArgs e)
    {
        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            Dispatcher.Invoke(() =>
            {
                messages.Items.Add($"{user}: {message}");
            });

            return Task.CompletedTask;
        });

        hubConnection.On<string, string>("GroupMessage", (user, message) =>
        {
            Dispatcher.Invoke(() =>
            {
                messages.Items.Add($"Group1_{user}: {message}");
            });

            return Task.CompletedTask;
        });

        try
        {
            await hubConnection.StartAsync();
            messages.Items.Add("Connection Started");
            openConnection.IsEnabled = false;
            sendMessage.IsEnabled = true;
            await hubConnection.InvokeAsync("SendStatus", userName.Content, true);
        }
        catch (Exception exception)
        {
            messages.Items.Add(exception.Message);
        }
    }

    private async void sendMessage_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (isInGroup)
            {
                await hubConnection.InvokeAsync("SendToGroup", userName.Content, messageInput.Text, "Group1");
            }
            else
            {
                await hubConnection.InvokeAsync("SendMessages", userName.Content, messageInput.Text);
            }
        }
        catch (Exception exception)
        {
            messages.Items.Add(exception.Message);
        }
    }

    private async void closeConnection_Click(object sender, RoutedEventArgs e)
    {
        await hubConnection.InvokeAsync("SendStatus", userName.Content, false);
        await hubConnection.StopAsync();

    }

    private async void joinGroup_Click(object sender, RoutedEventArgs e)
    {
        await hubConnection.InvokeAsync("JoinGroup", "Group1");
        joinedGroup.Content = "Joined Group1";
        isInGroup = true;
    }

    private async void leaveGroup_Click(object sender, RoutedEventArgs e)
    {
        await hubConnection.InvokeAsync("LeaveGroup", "Group1");
        joinedGroup.Content = "Not in any group";
        isInGroup = false;
    }
}