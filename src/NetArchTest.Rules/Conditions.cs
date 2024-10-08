﻿namespace NetArchTest.Rules
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A set of conditions that can be applied to a list of types.
    /// </summary>
    public sealed class Conditions
    {
        /// <summary>
        /// The parant to dispose.
        /// </summary>
        private readonly Types _types;

        /// <summary>
        /// The sequence of conditions that is applied to the type of list.
        /// </summary>
        private readonly FunctionSequence _sequence;

        /// <summary>
        /// Determines the polarity of the selection, i.e. "should" or "should not".
        /// </summary>
        private readonly bool _should;

        /// <summary>
        /// Initializes a new instance of the <see cref="Conditions"/> class.
        /// </summary>
        internal Conditions(Types types, bool should)
        {
            _types = types;
            _should = should;
            _sequence = new FunctionSequence();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Conditions"/> class.
        /// </summary>
        internal Conditions(Types types, bool should, FunctionSequence calls)
        {
            _types = types;
            _should = should;
            _sequence = calls;
        }

        /// <summary>
        /// Selects types that have a specific name.
        /// </summary>
        /// <param name="name">The name of the class to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveName(string name)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveName, name, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that do not have a particular name.
        /// </summary>
        /// <param name="name">The name of the class to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveName(string name)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveName, name, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types according to a regular expression matching their name.
        /// </summary>
        /// <param name="pattern">The regular expression pattern to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveNameMatching(string pattern)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveNameMatching, pattern, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types according to a regular expression that does not match their name.
        /// </summary>
        /// <param name="pattern">The regular expression pattern to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveNameMatching(string pattern)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveNameMatching, pattern, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose names start with the specified text.
        /// </summary>
        /// <param name="start">The text to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveNameStartingWith(string start)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveNameStartingWith, start, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose names start with the specified text.
        /// </summary>
        /// <param name="start">The text to match against.</param>
        /// <param name="comparer">The string comparer.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveNameStartingWith(string start, StringComparison comparer)
        {
            _sequence.AddFunctionCall(FunctionDelegates.MakeFunctionDelegateUsingStringComparerForHaveNameStartingWith(comparer), start, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose names do not start with the specified text.
        /// </summary>
        /// <param name="start">The text to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveNameStartingWith(string start)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveNameStartingWith, start, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose names do not start with the specified text.
        /// </summary>
        /// <param name="start">The text to match against.</param>
        /// <param name="comparer">The string comparer.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveNameStartingWith(string start, StringComparison comparer)
        {
            _sequence.AddFunctionCall(FunctionDelegates.MakeFunctionDelegateUsingStringComparerForHaveNameStartingWith(comparer), start, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose names do not end with the specified text.
        /// </summary>
        /// <param name="end">The text to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveNameEndingWith(string end)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveNameEndingWith, end, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose names do not end with the specified text.
        /// </summary>
        /// <param name="end">The text to match against.</param>
        /// <param name="comparer">The string comparer.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveNameEndingWith(string end, StringComparison comparer)
        {
            _sequence.AddFunctionCall(FunctionDelegates.MakeFunctionDelegateUsingStringComparerForHaveNameEndingWith(comparer), end, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose names do not end with the specified text.
        /// </summary>
        /// <param name="end">The text to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveNameEndingWith(string end)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveNameEndingWith, end, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose names do not end with the specified text.
        /// </summary>
        /// <param name="end">The text to match against.</param>
        /// <param name="comparer">The string comparer.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveNameEndingWith(string end, StringComparison comparer)
        {
            _sequence.AddFunctionCall(FunctionDelegates.MakeFunctionDelegateUsingStringComparerForHaveNameEndingWith(comparer), end, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that have a specific full name.
        /// </summary>
        /// <param name="fullName">The full name of the class to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveFullName(string fullName)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveFullName, fullName, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that do not have a particular full name.
        /// </summary>
        /// <param name="fullName">The full name of the class to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveFullName(string fullName)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveFullName, fullName, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types according to a regular expression matching their full name.
        /// </summary>
        /// <param name="pattern">The regular expression pattern to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveFullNameMatching(string pattern)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveFullNameMatching, pattern, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types according to a regular expression that does not match their full name.
        /// </summary>
        /// <param name="pattern">The regular expression pattern to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveFullNameMatching(string pattern)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveFullNameMatching, pattern, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose full names start with the specified text.
        /// </summary>
        /// <param name="start">The text to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveFullNameStartingWith(string start)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveFullNameStartingWith, start, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose full names start with the specified text.
        /// </summary>
        /// <param name="start">The text to match against.</param>
        /// <param name="comparer">The string comparer.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveFullNameStartingWith(string start, StringComparison comparer)
        {
            _sequence.AddFunctionCall(FunctionDelegates.MakeFunctionDelegateUsingStringComparerForHaveFullNameStartingWith(comparer), start, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose full names do not start with the specified text.
        /// </summary>
        /// <param name="start">The text to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveFullNameStartingWith(string start)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveFullNameStartingWith, start, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose full names do not start with the specified text.
        /// </summary>
        /// <param name="start">The text to match against.</param>
        /// <param name="comparer">The string comparer.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveFullNameStartingWith(string start, StringComparison comparer)
        {
            _sequence.AddFunctionCall(FunctionDelegates.MakeFunctionDelegateUsingStringComparerForHaveFullNameStartingWith(comparer), start, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose full names do not end with the specified text.
        /// </summary>
        /// <param name="end">The text to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveFullNameEndingWith(string end)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveFullNameEndingWith, end, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose full names do not end with the specified text.
        /// </summary>
        /// <param name="end">The text to match against.</param>
        /// <param name="comparer">The string comparer.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveFullNameEndingWith(string end, StringComparison comparer)
        {
            _sequence.AddFunctionCall(FunctionDelegates.MakeFunctionDelegateUsingStringComparerForHaveFullNameEndingWith(comparer), end, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose full names do not end with the specified text.
        /// </summary>
        /// <param name="end">The text to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveFullNameEndingWith(string end)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveFullNameEndingWith, end, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose full names do not end with the specified text.
        /// </summary>
        /// <param name="end">The text to match against.</param>
        /// <param name="comparer">The string comparer.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveFullNameEndingWith(string end, StringComparison comparer)
        {
            _sequence.AddFunctionCall(FunctionDelegates.MakeFunctionDelegateUsingStringComparerForHaveFullNameEndingWith(comparer), end, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types are decorated with a specific custom attribute.
        /// </summary>
        /// <param name="attribute">The attribute to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveCustomAttribute(Type attribute)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveCustomAttribute, attribute, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are not decorated with a specific custom attribute.
        /// </summary>
        /// <param name="attribute">The attribute to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveCustomAttribute(Type attribute)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveCustomAttribute, attribute, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are decorated with a specific custom attribute or derived one.
        /// </summary>
        /// <param name="attribute">The base attribute to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveCustomAttributeOrInherit(Type attribute)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveCustomAttributeOrInherit, attribute, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types are not decorated with a specific custom attribute or derived one.
        /// </summary>
        /// <param name="attribute">The base attribute to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveCustomAttributeOrInherit(Type attribute)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveCustomAttributeOrInherit, attribute, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that inherit a particular type.
        /// </summary>
        /// <param name="type">The type to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList Inherit(Type type)
        {
            _sequence.AddFunctionCall(FunctionDelegates.Inherits, type, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that do not inherit a particular type.
        /// </summary>
        /// <param name="type">The type to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotInherit(Type type)
        {
            _sequence.AddFunctionCall(FunctionDelegates.Inherits, type, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that implement a particular interface.
        /// </summary>
        /// <param name="interfaceType">The interface type to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList ImplementInterface(Type interfaceType)
        {
            _sequence.AddFunctionCall(FunctionDelegates.ImplementsInterface, interfaceType, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that do not implement a particular interface.
        /// </summary>
        /// <param name="interfaceType">The interface type to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotImplementInterface(Type interfaceType)
        {
            _sequence.AddFunctionCall(FunctionDelegates.ImplementsInterface, interfaceType, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are marked as abstract.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList BeAbstract()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeAbstract, true, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are not marked as abstract.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotBeAbstract()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeAbstract, true, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are classes.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList BeClasses()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeClass, true, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are not classes.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotBeClasses()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeClass, true, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that have generic parameters.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList BeGeneric()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeGeneric, true, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that do not have generic parameters.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotBeGeneric()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeGeneric, true, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are interfaces.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList BeInterfaces()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeInterface, true, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are not interfaces.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotBeInterfaces()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeInterface, true, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are static.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList BeStatic()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeStatic, true, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are not static.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotBeStatic()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeStatic, true, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are nested.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList BeNested()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeNested, true, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are nested and public.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList BeNestedPublic()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeNestedPublic, true, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are nested and private.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList BeNestedPrivate()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeNestedPrivate, true, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are not nested.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotBeNested()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeNested, true, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are not nested and public.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotBeNestedPublic()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeNestedPublic, true, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are not nested and private.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotBeNestedPrivate()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeNestedPrivate, true, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are have public scope.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList BePublic()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BePublic, true, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that do not have public scope.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotBePublic()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BePublic, true, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types according that are marked as sealed.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList BeSealed()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeSealed, true, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types according that are not marked as sealed.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotBeSealed()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeSealed, true, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are immutable.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList BeImmutable()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeImmutable, true, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that are mutable.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList BeMutable()
        {
            _sequence.AddFunctionCall(FunctionDelegates.BeImmutable, true, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types according to whether they have nullable members.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList OnlyHaveNullableMembers()
        {
            _sequence.AddFunctionCall(FunctionDelegates.HasNullableMembers, true, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types according to whether they have nullable members.
        /// </summary>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveSomeNonNullableMembers()
        {
            _sequence.AddFunctionCall(FunctionDelegates.HasNullableMembers, true, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that reside in a particular namespace.
        /// </summary>
        /// <param name="name">The namespace to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList ResideInNamespace(string name)
        {
            _sequence.AddFunctionCall(FunctionDelegates.ResideInNamespace, name, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that do not reside in a particular namespace.
        /// </summary>
        /// <param name="name">The namespace to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotResideInNamespace(string name)
        {
            _sequence.AddFunctionCall(FunctionDelegates.ResideInNamespace, name, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that reside in a namespace matching a regular expression.
        /// </summary>
        /// <param name="pattern">The regular expression pattern to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList ResideInNamespaceMatching(string pattern)
        {
            _sequence.AddFunctionCall(FunctionDelegates.ResideInNamespaceMatching, pattern, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that do not reside in a namespace matching a regular expression.
        /// </summary>
        /// <param name="pattern">The regular expression pattern to match against.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotResideInNamespaceMatching(string pattern)
        {
            _sequence.AddFunctionCall(FunctionDelegates.ResideInNamespaceMatching, pattern, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose namespaces start with a particular name part.
        /// </summary>
        /// <param name="name">The namespace part to match against.</param>
        /// <returns>An updated set of predicates that can be applied to a list of types.</returns>
        public ConditionList ResideInNamespaceStartingWith(string name)
        {
            _sequence.AddFunctionCall(FunctionDelegates.ResideInNamespaceMatching, $"^{name}", true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose namespaces start with a particular name part.
        /// </summary>
        /// <param name="name">The namespace part to match against.</param>
        /// <returns>An updated set of predicates that can be applied to a list of types.</returns>
        public ConditionList NotResideInNamespaceStartingWith(string name)
        {
            _sequence.AddFunctionCall(FunctionDelegates.ResideInNamespaceMatching, $"^{name}", false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose namespaces end with a particular name part.
        /// </summary>
        /// <param name="name">The namespace part to match against.</param>
        /// <returns>An updated set of predicates that can be applied to a list of types.</returns>
        public ConditionList ResideInNamespaceEndingWith(string name)
        {
            _sequence.AddFunctionCall(FunctionDelegates.ResideInNamespaceMatching, $"{name}$", true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose namespaces end with a particular name part.
        /// </summary>
        /// <param name="name">The namespace part to match against.</param>
        /// <returns>An updated set of predicates that can be applied to a list of types.</returns>
        public ConditionList NotResideInNamespaceEndingWith(string name)
        {
            _sequence.AddFunctionCall(FunctionDelegates.ResideInNamespaceMatching, $"{name}$", false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose namespaces contain a particular name part.
        /// </summary>
        /// <param name="name">The namespace part to match against.</param>
        /// <returns>An updated set of predicates that can be applied to a list of types.</returns>
        public ConditionList ResideInNamespaceContaining(string name)
        {
            _sequence.AddFunctionCall(FunctionDelegates.ResideInNamespaceMatching, $"^.*{name}.*$", true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types whose namespaces contain a particular name part.
        /// </summary>
        /// <param name="name">The namespace part to match against.</param>
        /// <returns>An updated set of predicates that can be applied to a list of types.</returns>
        public ConditionList NotResideInNamespaceContaining(string name)
        {
            _sequence.AddFunctionCall(FunctionDelegates.ResideInNamespaceMatching, $"^.*{name}.*$", false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that have a dependency on a particular type.
        /// </summary>
        /// <param name="dependency">The dependency to match against. This can be a namespace or a specific type.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveDependencyOn(string dependency)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveDependencyOnAny, new List<string> { dependency }, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that have a dependency on any of the supplied types.
        /// </summary>
        /// <param name="dependencies">The dependencies to match against. These can be namespaces or specific types.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveDependencyOnAny(IEnumerable<string> dependencies)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveDependencyOnAny, dependencies, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that have a dependency on any of the supplied types.
        /// </summary>
        /// <param name="dependency">The dependencies to match against. These can be namespaces or specific types.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveDependencyOnAny(string dependency) => HaveDependencyOnAny([dependency]);

        /// <summary>
        /// Selects types that have a dependency on any type matching the given regex pattern.
        /// </summary>
        /// <param name="pattern">The regex pattern that will be applied to the full type name.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveDependencyOnAnyMatching(string pattern)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveDependencyOnAnyMatching, pattern, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that have a dependency on all of the particular types.
        /// </summary>
        /// <param name="dependencies">The dependencies to match against. These can be namespaces or specific types.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveDependencyOnAll(IEnumerable<string> dependencies)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveDependencyOnAll, dependencies, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that have a dependency on all of the particular types.
        /// </summary>
        /// <param name="dependency">The dependencies to match against. These can be namespaces or specific types.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveDependencyOnAll(string dependency) => HaveDependencyOnAll([dependency]);

        /// <summary>
        /// Selects types that have a dependency on any of the supplied types and cannot have any other dependency. 
        /// </summary>
        /// <param name="dependencies">The dependencies to match against. These can be namespaces or specific types.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList OnlyHaveDependenciesOn(IEnumerable<string> dependencies)
        {
            _sequence.AddFunctionCall(FunctionDelegates.OnlyHaveDependenciesOnAnyOrNone, dependencies, true);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that have a dependency on any of the supplied types and cannot have any other dependency. 
        /// </summary>
        /// <param name="dependency">The dependencies to match against. These can be namespaces or specific types.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList OnlyHaveDependenciesOn(string dependency) => OnlyHaveDependenciesOn([dependency]);

        /// <summary>
        /// Selects types that do not have a dependency on a particular type.
        /// </summary>
        /// <param name="dependency">The dependency type to match against. This can be a namespace or a specific type.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveDependencyOn(string dependency)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveDependencyOnAny, new List<string> { dependency }, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that do not have a dependency on any of the particular types.
        /// </summary>
        /// <param name="dependencies">The dependencies to match against. These can be namespaces or specific types.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveDependencyOnAny(IEnumerable<string> dependencies)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveDependencyOnAny, dependencies, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that do not have a dependency on any of the particular types.
        /// </summary>
        /// <param name="dependency">The dependencies to match against. These can be namespaces or specific types.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveDependencyOnAny(string dependency) => NotHaveDependencyOnAny([dependency]);

        /// <summary>
        /// Selects types that do not have a dependency on any type matching the given regex pattern.
        /// </summary>
        /// <param name="pattern">The regex pattern that will be applied to the full type name.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveDependencyOnAnyMatching(string pattern)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveDependencyOnAnyMatching, pattern, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that do not have a dependency on all of the particular types.
        /// </summary>
        /// <param name="dependencies">The dependencies to match against. These can be namespaces or specific types.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveDependencyOnAll(IEnumerable<string> dependencies)
        {
            _sequence.AddFunctionCall(FunctionDelegates.HaveDependencyOnAll, dependencies, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that do not have a dependency on all of the particular types.
        /// </summary>
        /// <param name="dependency">The dependencies to match against. These can be namespaces or specific types.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList NotHaveDependencyOnAll(string dependency) => NotHaveDependencyOnAll([dependency]);

        /// <summary>
        /// Selects types that have a dependency other than any of the given dependencies.
        /// </summary>
        /// <param name="dependencies">The dependencies to match against. These can be namespaces or specific types.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveDependenciesOtherThan(IEnumerable<string> dependencies)
        {
            _sequence.AddFunctionCall(FunctionDelegates.OnlyHaveDependenciesOnAnyOrNone, dependencies, false);
            return new ConditionList(_types, _should, _sequence);
        }

        /// <summary>
        /// Selects types that have a dependency other than any of the given dependencies.
        /// </summary>
        /// <param name="dependency">The dependencies to match against. These can be namespaces or specific types.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList HaveDependenciesOtherThan(string dependency) => HaveDependenciesOtherThan([dependency]);

        /// <summary>
        /// Selects types that meet a custom rule.
        /// </summary>
        /// <param name="rule">An instance of the custom rule.</param>
        /// <returns>An updated set of conditions that can be applied to a list of types.</returns>
        public ConditionList MeetCustomRule(ICustomRule rule)
        {
            _sequence.AddFunctionCall(FunctionDelegates.MeetCustomRule, rule, true);
            return new ConditionList(_types, _should, _sequence);
        }
    }
}
