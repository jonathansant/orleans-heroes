﻿using Orleans;
using System.Threading.Tasks;

namespace Heroes.Contracts.UserNotifications
{
	public interface IUserNotificationGrain : IGrainWithStringKey
	{
		Task Set(UserNotification item);
		Task<UserNotification> Get();
	}
}