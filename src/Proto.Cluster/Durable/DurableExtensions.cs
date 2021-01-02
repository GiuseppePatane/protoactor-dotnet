// -----------------------------------------------------------------------
// <copyright file="DurableExtensions.cs" company="Asynkron AB">
//      Copyright (C) 2015-2020 Asynkron AB All rights reserved
// </copyright>
// -----------------------------------------------------------------------
using System.Threading.Tasks;

namespace Proto.Cluster.Durable
{
    public static class DurableExtensions
    {
        public static ActorSystem WithDurableFunctions(this ActorSystem system)
        {
            var p = new DurablePlugin(system.Cluster());
            system.Extensions.Register(p);
            return system;
        }
    }
}