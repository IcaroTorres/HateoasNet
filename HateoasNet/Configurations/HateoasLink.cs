﻿using System;
using System.Collections.Generic;
using HateoasNet.Abstractions;

namespace HateoasNet.Configurations
{
	/// <inheritdoc cref="IHateoasLink" />
	public sealed class HateoasLink<T> : IHateoasLink<T> where T : class
	{
		internal HateoasLink(string routeName) : this(routeName, e => null, e => true)
		{
		}

		private HateoasLink(string routeName,
		                    Func<T, IDictionary<string, object>> routeDictionaryFunction,
		                    Func<T, bool> predicate)
		{
			RouteName = routeName;
			RouteDictionaryFunction = routeDictionaryFunction;
			Predicate = predicate;
		}

		public string RouteName { get; }
		public Func<T, bool> Predicate { get; private set; }
		public Func<T, IDictionary<string, object>> RouteDictionaryFunction { get; private set; }

		public IDictionary<string, object> GetRouteDictionary(object resourceData)
		{
			if (resourceData == null) throw new ArgumentNullException(nameof(resourceData));

			return RouteDictionaryFunction((T) resourceData);
		}

		public bool IsApplicable(object resourceData)
		{
			if (resourceData == null) throw new ArgumentNullException(nameof(resourceData));

			return Predicate((T) resourceData);
		}

		public IHateoasLink<T> HasRouteData(Func<T, object> routeDataFunction)
		{
			if (routeDataFunction == null) throw new ArgumentNullException(nameof(routeDataFunction));
			RouteDictionaryFunction = source => routeDataFunction(source).ToRouteDictionary();
			return this;
		}

		public IHateoasLink<T> HasConditional(Func<T, bool> predicate)
		{
			Predicate = predicate ?? throw new ArgumentNullException(nameof(predicate));
			return this;
		}
	}
}
