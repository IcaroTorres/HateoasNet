﻿using System;
using System.Collections;
using HateoasNet.Resources;

namespace HateoasNet.Abstractions
{
	/// <summary>
	///   Represents a Factory for creation of formatted <see cref="Resource" /> output instances.
	/// </summary>
	public interface IResourceFactory
	{
		/// <summary>
		///   Creates a formatted <see cref="SingleResource" /> using <see cref="IHateoasResource{T}" /> configuration
		///   of <paramref name="type" /> with <paramref name="source" /> as original value.
		/// </summary>
		/// <param name="source">Original value to wrap in a <see cref="SingleResource" />.</param>
		/// <param name="type">type parameter of <see cref="IHateoasResource{T}" />  configuration.</param>
		/// <returns>A formatted <see cref="SingleResource" /> instance.</returns>
		Resource Create(object source, Type type);

		/// <summary>
		///   Creates a formatted <see cref="EnumerableResource{Resource}" /> using <see cref="IHateoasResource{T}" />
		///   configuration
		///   of <paramref name="type" /> with <paramref name="source" /> as original value.
		/// </summary>
		/// <param name="source">Original value to wrap in a <see cref="SingleResource" /></param>
		/// <param name="type">type parameter of <see cref="IHateoasResource{T}" /> configuration.</param>
		/// <returns>A formatted <see cref="EnumerableResource{Resource}" /> instance.</returns>
		Resource Create(IEnumerable source, Type type);

		/// <summary>
		///   Creates a formatted <see cref="PaginationResource{Resource}" /> using <see cref="IHateoasResource{T}" />
		///   configuration of <paramref name="type" /> with <paramref name="source" /> as original value.
		/// </summary>
		/// <param name="source">Original value to wrap in a <see cref="SingleResource" /></param>
		/// <param name="type">type parameter of <see cref="IHateoasResource{T}" /> configuration.</param>
		/// <returns>A formatted <see cref="PaginationResource{Resource}" /> instance.</returns>
		Resource Create(IPagination source, Type type);

		/// <summary>
		///   Builds the <see cref="Resource.Links" /> collection for created <see cref="Resource" />.
		/// </summary>
		/// <param name="resource">Original value Formatted as <see cref="Resource" /> instance.</param>
		/// <param name="type">
		///   type parameter of <see cref="IHateoasLink{T}" /> configuration to builds the <see cref="Resource.Links" />.
		/// </param>
		/// <returns>A formatted <see cref="PaginationResource{Resource}" /> instance.</returns>
		Resource BuildResourceLinks(Resource resource, Type type);
	}
}