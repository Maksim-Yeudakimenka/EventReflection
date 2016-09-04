using System;

namespace EventReflection
{
    public class EventRegistrar
    {
        public static void RegisterEvent(
            object provider,
            string eventName,
            object subscriber,
            string handlerName)
        {
            var providerType = provider.GetType();
            var eventInfo = providerType.GetEvent(eventName);

            var eventHandler = Delegate.CreateDelegate(eventInfo.EventHandlerType, subscriber, handlerName);

            eventInfo.AddEventHandler(provider, eventHandler);
        }
    }
}