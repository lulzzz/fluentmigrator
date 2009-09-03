﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using FluentMigrator.Expressions;
using FluentMigrator.Runner.Generators;
using FluentMigrator.Runner.Processors;
using NUnit.Framework;

namespace FluentMigrator.Tests.Integration.Processors
{
	[TestFixture]
	public class FileDumpProcessorTests
	{
		[Test]
		public void CanDumpCreateTableExpression()
		{
//			string testTableName = "sample_table";
//			var fileDumpProcessor = new FileDumpProcessor(new SqliteGenerator());
//			CreateTableExpression expression = new CreateTableExpression { TableName = testTableName };
//			fileDumpProcessor.Process(expression);
//

		}
	}

	public class FileDumpProcessor : ProcessorBase
	{
		public FileDumpProcessor(IMigrationGenerator generator)
		{
			DumpFilename = string.Format("dump_{0}.sql", DateTime.Now.ToShortDateString());
			File.Delete(DumpFilename);
			this.generator = generator;
		}

		
		protected string DumpFilename { get; set; }

		protected override void Process(string sql)
		{
			File.AppendAllText(DumpFilename, sql);
		}

		public override void Execute(string template, params object[] args)
		{
			throw new NotImplementedException();
		}

		public override void UpdateTable(string tableName, List<string> columns, List<string> formattedValues)
		{
			throw new NotImplementedException();
		}

		public override DataSet ReadTableData(string tableName)
		{
			throw new NotImplementedException();
		}

		public override DataSet Read(string template, params object[] args)
		{
			throw new NotImplementedException();
		}

		public override bool TableExists(string tableName)
		{
			throw new NotImplementedException();
		}

		public override bool Exists(string template, params object[] args)
		{
			throw new NotImplementedException();
		}
	}
}
