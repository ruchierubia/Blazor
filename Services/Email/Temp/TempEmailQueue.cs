
using BlazorEmployeeManagement.Models.Temp;
using System.Threading;
using System.Threading.Channels;

namespace BlazorEmployeeManagement.Services.Email.Temp
{

    // TEMPORARY:
    // In-memory email queue using Channel<T>.
    public class TempEmailQueue : IEmailQueue
    {

        private readonly Channel<TempEmailMessage> _channel;

        public TempEmailQueue()
        {
            _channel = Channel.CreateUnbounded<TempEmailMessage>();
        }

        public async ValueTask<TempEmailMessage> DequeueAsync(CancellationToken cancellationToken)
        {
            return await _channel.Reader.ReadAsync(cancellationToken);
        }

        public async ValueTask QueueAsync(TempEmailMessage email)
        {
            await _channel.Writer.WriteAsync(email);
        }
    }
}
