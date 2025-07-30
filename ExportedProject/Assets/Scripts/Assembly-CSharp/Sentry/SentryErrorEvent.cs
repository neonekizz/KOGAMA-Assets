using System.Collections.Generic;

namespace Sentry
{
	public class SentryErrorEvent : SentryEvent
	{
		public SentryErrorEvent(string message, List<Breadcrumb> breadcrumbs, string stackTrace, Dictionary<string, string> tags, Dictionary<string, object> extra)
			: base(null, null, null)
		{
		}
	}
}
