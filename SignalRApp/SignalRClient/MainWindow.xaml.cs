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
    public MainWindow()
    {
        InitializeComponent();
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
        try
        {
            await hubConnection.StartAsync();
            messages.Items.Add("Connection Started");
            openConnection.IsEnabled = false;
            sendMessage.IsEnabled = true;
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
            await hubConnection.InvokeAsync("SendMessages", "WPF Client", messageInput.Text);
        }
        catch (Exception exception)
        {
            messages.Items.Add(exception.Message);
        }
    }
}