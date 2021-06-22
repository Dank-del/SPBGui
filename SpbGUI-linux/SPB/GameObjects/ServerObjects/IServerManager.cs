// Spam Protection Bot GUI
// Copyright (C) 2019 - 2021 ALiwoto
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of the source code.

using WotoProvider.Interfaces;
using SPB.Security;
using SPB.LoadingService;
using SPB.GameObjects.Item;
using SPB.GameObjects.Heroes;
using SPB.GameObjects.Players;
using SPB.GameObjects.Kingdoms;
using SPB.GameObjects.Chatting;

namespace SPB.GameObjects.ServerObjects
{
    public interface IServerManager
    {
        //-------------------------------------------------
        #region Properties Region

        #endregion
        //-------------------------------------------------
        #region Method's Region
        IServerProvider<QString, DataBaseClient> Get_Main_Server();
        IServerProvider<QString, DataBaseClient> Get_Channel_Server(ChatChannels _channel_);
        IServerProvider<QString, DataBaseClient> Get_Kingdom_Server(SPB_Kingdoms _kingdom_);
        IServerProvider<QString, DataBaseClient> Get_UID_Server(in StrongString _username_);
        IServerProvider<QString, DataBaseClient> Get_UID_Generation_Server(in int _index_);
        IServerProvider<QString, DataBaseClient> Get_UID_Server(in int _index_);
        IServerProvider<QString, DataBaseClient> Get_UID_Server(in UID _id_);
        IServerProvider<QString, DataBaseClient> Get_Login_Server(in IPlayerSocket _socket_);
        IServerProvider<QString, DataBaseClient> Get_PlayerInfo_Server(in IPlayerSocket _socket_);
        IServerProvider<QString, DataBaseClient> Get_Me_Server(in IPlayerSocket _socket_);
        IServerProvider<QString, DataBaseClient> Get_Player_Server(in IPlayerSocket _socket_);
        IServerProvider<QString, DataBaseClient> Get_Troops_Server(in IPlayerSocket _socket_);
        IServerProvider<QString, DataBaseClient> Get_MagicalTroops_Server(in IPlayerSocket _socket_);
        IServerProvider<QString, DataBaseClient> Get_Resources_Server(in IPlayerSocket _socket_);
        IServerProvider<QString, DataBaseClient> Get_PlayerHeroSocket_Server(in IPlayerSocket _socket_);
        IServerProvider<QString, DataBaseClient> Get_SecuredMe_Server(in IPlayerSocket _socket_);
        IServerProvider<QString, DataBaseClient> Get_PlayerItemsSocket_Server(in IPlayerSocket _socket_);
        IServerProvider<QString, DataBaseClient> Get_GeneralItems_Server(in IItemSocket _socket_);
        IServerProvider<QString, DataBaseClient> Get_WeaponsItems_Server(in IItemSocket _socket_);
        IServerProvider<QString, DataBaseClient> Get_WarExtraItems_Server(in IItemSocket _socket_);
        IServerProvider<QString, DataBaseClient> Get_CurrencyItems_Server(in IItemSocket _socket_);
        IServerProvider<QString, DataBaseClient> Get_EventItems_Server(in IItemSocket _socket_);
        IServerProvider<QString, DataBaseClient> Get_HeroesShardsItems_Server(in IItemSocket _socket_);
        IServerProvider<QString, DataBaseClient> Get_GiftItems_Server(in IItemSocket _socket_);
        IServerProvider<QString, DataBaseClient> Get_HeroInfo_Server(in IHeroSocket _socket_);
        IServerProvider<QString, DataBaseClient> Get_NPCInfo_Server();
        #endregion
        //-------------------------------------------------
    }
}
