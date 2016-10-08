﻿using Model = Discord.API.Rpc.GuildCreatedEvent;

namespace Discord.Rpc
{
    public class RpcGuild
    {
        public ulong Id { get; }
        public string Name { get; set; }

        internal RpcGuild(ulong id)
        {
            Id = id;
        }
        internal static RpcGuild Create(Model model)
        {
            var entity = new RpcGuild(model.Id);
            entity.Update(model);
            return entity;
        }
        internal void Update(Model model)
        {
            Name = model.Name;
        }
    }
}
