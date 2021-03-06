﻿//  Copyright (c) 2019 Alachisoft
//  
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  
//     http://www.apache.org/licenses/LICENSE-2.0
//  
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License
using Alachisoft.NCache.Runtime.Events;

namespace Alachisoft.NCache.Caching.Events
{
    internal static class EventsUtil
    {
        internal static EventTypeInternal GetEventTypeInternal(Runtime.Events.EventType eventType)
        {
            EventTypeInternal eventTypeInternal = EventTypeInternal.None;

            if ((eventType & EventType.ItemAdded) != 0)
                eventTypeInternal |= EventTypeInternal.ItemAdded;

            if ((eventType & EventType.ItemUpdated) != 0)
                eventTypeInternal |= EventTypeInternal.ItemUpdated;

            if ((eventType & EventType.ItemRemoved) != 0)
                eventTypeInternal |= EventTypeInternal.ItemRemoved;

            return eventTypeInternal;
        }
    }
}
