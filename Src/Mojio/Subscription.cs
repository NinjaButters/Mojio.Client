﻿using Mojio.Converters;
using Mojio.Events;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mojio
{
    /// <summary>
    /// Subscription Type
    /// </summary>
    public enum SubscriptionType
    {
        /// <summary>The mojio</summary>
        Mojio = 1,
        /// <summary>The trip</summary>
        Trip,
        /// <summary>The user</summary>
        User,
    }

    /// <summary>
    /// Channel Type
    /// </summary>
    public enum ChannelType
    {
        /// <summary>The apple</summary>
        Apple,
        /// <summary>The android</summary>
        Android,
        /// <summary>The windows</summary>
        Windows,
        /// <summary>The post</summary>
        Post,
        /// <summary>The signal r</summary>
        SignalR
    }

    /// <summary>
    /// Subscription
    /// </summary>
    [JsonConverter (typeof(SubscriptionConverter))]
    public partial class Subscription : GuidEntity, IOwner
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription"/> class.
        /// </summary>
        public Subscription ()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        public Subscription (EventType type)
        {
            Event = type;
        }

        /// <summary>Gets or sets the type of the channel.</summary>
        /// <value>The type of the channel.</value>
        public ChannelType ChannelType { get; set; }

        /// <summary>Gets or sets the channel target.</summary>
        /// <value>The channel target.</value>
        public string ChannelTarget { get; set; }

        /// <summary>Gets or sets the application identifier.</summary>
        /// <value>The application identifier.</value>
        public Guid AppId { get; set; }

        /// <summary>owner id</summary>
        public Guid? OwnerId { get; set; }

        /// <summary>Gets or sets the event.</summary>
        /// <value>The event.</value>
        public EventType Event { get; set; }

        /// <summary>Gets or sets the type of the entity.</summary>
        /// <value>The type of the entity.</value>
        public SubscriptionType EntityType { get; set; }

        /// <summary>Gets or sets the entity identifier.</summary>
        /// <value>The entity identifier.</value>
        public string EntityId { get; set; }

        /// <summary>Gets or sets the interval.</summary>
        /// <value>The interval.</value>
        public int Interval { get; set; }

        /// <summary>Gets or sets the last message.</summary>
        /// <value>The last message.</value>
        public DateTime? LastMessage { get; set; }
    }

    /// <summary>
    /// Hard Subscription
    /// </summary>
    [CollectionNameAttribute (typeof(Subscription))]
    public partial class HardSubscription : Subscription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HardSubscription"/> class.
        /// </summary>
        public HardSubscription ()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HardSubscription"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="maxForce">The maximum force.</param>
        public HardSubscription (EventType type, float maxForce = 1f) : base (type)
        {
            MaxForce = maxForce;
        }

        /// <summary>Gets or sets the maximum force.</summary>
        /// <value>The maximum force.</value>
        public float MaxForce { get; set; }
    }

    /// <summary>
    /// Speed Subscription
    /// </summary>
    [CollectionNameAttribute (typeof(Subscription))]
    public partial class SpeedSubscription : Subscription
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpeedSubscription"/> class.
        /// </summary>
        public SpeedSubscription ()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeedSubscription"/> class.
        /// </summary>
        /// <param name="maxSpeed">The maximum speed.</param>
        /// <param name="interval">The interval.</param>
        public SpeedSubscription (float maxSpeed = 65f, int interval = 60) : base (EventType.Speed)
        {
            MaxSpeed = maxSpeed;
            Interval = 60;
        }

        /// <summary>Gets or sets the maximum speed.</summary>
        /// <value>The maximum speed.</value>
        public float MaxSpeed { get; set; }
    }
}