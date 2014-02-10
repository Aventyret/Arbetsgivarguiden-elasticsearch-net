using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using NUnit.Framework;
using Nest.Tests.Integration.Yaml;


namespace Nest.Tests.Integration.Yaml.IndicesExists
{
	public partial class IndicesExists10BasicYaml10Tests
	{
		
		public class TestIndicesExists10Tests : YamlTestsBase
		{
			private readonly RawElasticClient _client;
			private object _body;
			private ConnectionStatus _status;
			private dynamic _response;
		
			public TestIndicesExists10Tests()
			{
				var uri = new Uri("http:localhost:9200");
				var settings = new ConnectionSettings(uri, "nest-default-index");
				_client = new RawElasticClient(settings);
			}

			[Test]
			public void TestIndicesExistsTests()
			{

				//do indices.exists 
				
				_status = this._client.IndicesExistsHead("test_index");
				_response = _status.Deserialize<dynamic>();

				//is_false ; 
				this.IsFalse(_response);

				//do indices.create 
				
				_status = this._client.IndicesCreatePost("test_index", null);
				_response = _status.Deserialize<dynamic>();

				//do indices.exists 
				
				_status = this._client.IndicesExistsHead("test_index");
				_response = _status.Deserialize<dynamic>();

				//is_true ; 
				this.IsTrue(_response);
			}
		}
	}
}
