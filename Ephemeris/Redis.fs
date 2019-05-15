module Redis
open System
open Message

type IRedis = {
    Id: Guid
}   // Not sure what the base type actually needs to have here, RedisConnection maybe?
    // Connection Multiplexer?
with
    static member PushToQueue<'t> (queueName: string) (message: Message<'t>) =
        ()
    
    