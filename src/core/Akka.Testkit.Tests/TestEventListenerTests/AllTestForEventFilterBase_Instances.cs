﻿using Akka.Event;

namespace Akka.Testkit.Tests.TestEventListenerTests
{
    public class EventFilterDebugTests : AllTestForEventFilterBase<Debug>
    {
        public EventFilterDebugTests() : base("akka.loglevel=DEBUG"){}

        protected override void PublishMessage(object message, string source)
        {
            Sys.EventStream.Publish(new Debug(source,GetType(),message));
        }
    }

    public class EventFilterInfoTests : AllTestForEventFilterBase<Info>
    {
        public EventFilterInfoTests() : base("akka.loglevel=INFO") { }

        protected override void PublishMessage(object message, string source)
        {
            Sys.EventStream.Publish(new Info(source, GetType(), message));
        }
    }

    public class EventFilterWarningTests : AllTestForEventFilterBase<Warning>
    {
        public EventFilterWarningTests() : base("akka.loglevel=WARNING") { }

        protected override void PublishMessage(object message, string source)
        {
            Sys.EventStream.Publish(new Warning(source, GetType(), message));
        }
    }

    public class EventFilterErrorTests : AllTestForEventFilterBase<Error>
    {
        public EventFilterErrorTests() : base("akka.loglevel=ERROR") { }

        protected override void PublishMessage(object message, string source)
        {
            Sys.EventStream.Publish(new Error(null, source, GetType(), message));
        }
    }
}