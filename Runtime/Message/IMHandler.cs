using System;

namespace Framework.NetworkPackage
{
	public interface IMHandler
	{
		EVoid Handle(Session session, object message);
		Type GetMessageType();
	}
}