using Confluent.Kafka;

var config = new ProducerConfig
{
    BootstrapServers = "localhost:9092"
};

using var producer = new ProducerBuilder<Null, string>(config).Build();

Console.WriteLine("Kafka Chat Publisher");
Console.WriteLine("Type message (type exit to stop)");

while (true)
{
    string message = Console.ReadLine();

    if (message.ToLower() == "exit")
        break;

    var result = await producer.ProduceAsync("chat-topic",
        new Message<Null, string>
        {
            Value = message
        });

    Console.WriteLine($"Sent : {message}");
}
