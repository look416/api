/* 
 * Tradovate API
 *
 * A motivational message should be here.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Tradovate.Services.Client;
using Tradovate.Services.Api;
using Tradovate.Services.Model;

namespace Tradovate.Services.Test
{
    /// <summary>
    ///  Class for testing OrdersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrdersApiTests
    {
        private OrdersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrdersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrdersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrdersApi
            //Assert.IsInstanceOfType(typeof(OrdersApi), instance, "instance is a OrdersApi");
        }

        
        /// <summary>
        /// Test CancelOrder
        /// </summary>
        [Test]
        public void CancelOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CancelOrder body = null;
            //var response = instance.CancelOrder(body);
            //Assert.IsInstanceOf<CommandResult> (response, "response is CommandResult");
        }
        
        /// <summary>
        /// Test FindExecutionReport
        /// </summary>
        [Test]
        public void FindExecutionReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.FindExecutionReport(name);
            //Assert.IsInstanceOf<ExecutionReport> (response, "response is ExecutionReport");
        }
        
        /// <summary>
        /// Test GetAllCommandReports
        /// </summary>
        [Test]
        public void GetAllCommandReportsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllCommandReports();
            //Assert.IsInstanceOf<List<CommandReport>> (response, "response is List<CommandReport>");
        }
        
        /// <summary>
        /// Test GetAllCommands
        /// </summary>
        [Test]
        public void GetAllCommandsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllCommands();
            //Assert.IsInstanceOf<List<Command>> (response, "response is List<Command>");
        }
        
        /// <summary>
        /// Test GetAllExecutionReports
        /// </summary>
        [Test]
        public void GetAllExecutionReportsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllExecutionReports();
            //Assert.IsInstanceOf<List<ExecutionReport>> (response, "response is List<ExecutionReport>");
        }
        
        /// <summary>
        /// Test GetAllFillFees
        /// </summary>
        [Test]
        public void GetAllFillFeesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllFillFees();
            //Assert.IsInstanceOf<List<FillFee>> (response, "response is List<FillFee>");
        }
        
        /// <summary>
        /// Test GetAllFills
        /// </summary>
        [Test]
        public void GetAllFillsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllFills();
            //Assert.IsInstanceOf<List<Fill>> (response, "response is List<Fill>");
        }
        
        /// <summary>
        /// Test GetAllOrderStrategies
        /// </summary>
        [Test]
        public void GetAllOrderStrategiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllOrderStrategies();
            //Assert.IsInstanceOf<List<OrderStrategy>> (response, "response is List<OrderStrategy>");
        }
        
        /// <summary>
        /// Test GetAllOrderStrategyLinks
        /// </summary>
        [Test]
        public void GetAllOrderStrategyLinksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllOrderStrategyLinks();
            //Assert.IsInstanceOf<List<OrderStrategyLink>> (response, "response is List<OrderStrategyLink>");
        }
        
        /// <summary>
        /// Test GetAllOrderStrategyLogs
        /// </summary>
        [Test]
        public void GetAllOrderStrategyLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllOrderStrategyLogs();
            //Assert.IsInstanceOf<List<OrderStrategyLog>> (response, "response is List<OrderStrategyLog>");
        }
        
        /// <summary>
        /// Test GetAllOrderVersions
        /// </summary>
        [Test]
        public void GetAllOrderVersionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllOrderVersions();
            //Assert.IsInstanceOf<List<OrderVersion>> (response, "response is List<OrderVersion>");
        }
        
        /// <summary>
        /// Test GetAllOrders
        /// </summary>
        [Test]
        public void GetAllOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAllOrders();
            //Assert.IsInstanceOf<List<Order>> (response, "response is List<Order>");
        }
        
        /// <summary>
        /// Test GetCommand
        /// </summary>
        [Test]
        public void GetCommandTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetCommand(id);
            //Assert.IsInstanceOf<Command> (response, "response is Command");
        }
        
        /// <summary>
        /// Test GetCommandReport
        /// </summary>
        [Test]
        public void GetCommandReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetCommandReport(id);
            //Assert.IsInstanceOf<CommandReport> (response, "response is CommandReport");
        }
        
        /// <summary>
        /// Test GetCommandReports
        /// </summary>
        [Test]
        public void GetCommandReportsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> ids = null;
            //var response = instance.GetCommandReports(ids);
            //Assert.IsInstanceOf<List<CommandReport>> (response, "response is List<CommandReport>");
        }
        
        /// <summary>
        /// Test GetCommands
        /// </summary>
        [Test]
        public void GetCommandsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> ids = null;
            //var response = instance.GetCommands(ids);
            //Assert.IsInstanceOf<List<Command>> (response, "response is List<Command>");
        }
        
        /// <summary>
        /// Test GetExecutionReport
        /// </summary>
        [Test]
        public void GetExecutionReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetExecutionReport(id);
            //Assert.IsInstanceOf<ExecutionReport> (response, "response is ExecutionReport");
        }
        
        /// <summary>
        /// Test GetExecutionReports
        /// </summary>
        [Test]
        public void GetExecutionReportsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> ids = null;
            //var response = instance.GetExecutionReports(ids);
            //Assert.IsInstanceOf<List<ExecutionReport>> (response, "response is List<ExecutionReport>");
        }
        
        /// <summary>
        /// Test GetFill
        /// </summary>
        [Test]
        public void GetFillTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetFill(id);
            //Assert.IsInstanceOf<Fill> (response, "response is Fill");
        }
        
        /// <summary>
        /// Test GetFillFee
        /// </summary>
        [Test]
        public void GetFillFeeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetFillFee(id);
            //Assert.IsInstanceOf<FillFee> (response, "response is FillFee");
        }
        
        /// <summary>
        /// Test GetFillFees
        /// </summary>
        [Test]
        public void GetFillFeesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> ids = null;
            //var response = instance.GetFillFees(ids);
            //Assert.IsInstanceOf<List<FillFee>> (response, "response is List<FillFee>");
        }
        
        /// <summary>
        /// Test GetFills
        /// </summary>
        [Test]
        public void GetFillsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> ids = null;
            //var response = instance.GetFills(ids);
            //Assert.IsInstanceOf<List<Fill>> (response, "response is List<Fill>");
        }
        
        /// <summary>
        /// Test GetOrder
        /// </summary>
        [Test]
        public void GetOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetOrder(id);
            //Assert.IsInstanceOf<Order> (response, "response is Order");
        }
        
        /// <summary>
        /// Test GetOrderStrategies
        /// </summary>
        [Test]
        public void GetOrderStrategiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> ids = null;
            //var response = instance.GetOrderStrategies(ids);
            //Assert.IsInstanceOf<List<OrderStrategy>> (response, "response is List<OrderStrategy>");
        }
        
        /// <summary>
        /// Test GetOrderStrategy
        /// </summary>
        [Test]
        public void GetOrderStrategyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetOrderStrategy(id);
            //Assert.IsInstanceOf<OrderStrategy> (response, "response is OrderStrategy");
        }
        
        /// <summary>
        /// Test GetOrderStrategyLink
        /// </summary>
        [Test]
        public void GetOrderStrategyLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetOrderStrategyLink(id);
            //Assert.IsInstanceOf<OrderStrategyLink> (response, "response is OrderStrategyLink");
        }
        
        /// <summary>
        /// Test GetOrderStrategyLinks
        /// </summary>
        [Test]
        public void GetOrderStrategyLinksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> ids = null;
            //var response = instance.GetOrderStrategyLinks(ids);
            //Assert.IsInstanceOf<List<OrderStrategyLink>> (response, "response is List<OrderStrategyLink>");
        }
        
        /// <summary>
        /// Test GetOrderStrategyLog
        /// </summary>
        [Test]
        public void GetOrderStrategyLogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetOrderStrategyLog(id);
            //Assert.IsInstanceOf<OrderStrategyLog> (response, "response is OrderStrategyLog");
        }
        
        /// <summary>
        /// Test GetOrderStrategyLogs
        /// </summary>
        [Test]
        public void GetOrderStrategyLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> ids = null;
            //var response = instance.GetOrderStrategyLogs(ids);
            //Assert.IsInstanceOf<List<OrderStrategyLog>> (response, "response is List<OrderStrategyLog>");
        }
        
        /// <summary>
        /// Test GetOrderVersion
        /// </summary>
        [Test]
        public void GetOrderVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetOrderVersion(id);
            //Assert.IsInstanceOf<OrderVersion> (response, "response is OrderVersion");
        }
        
        /// <summary>
        /// Test GetOrderVersions
        /// </summary>
        [Test]
        public void GetOrderVersionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> ids = null;
            //var response = instance.GetOrderVersions(ids);
            //Assert.IsInstanceOf<List<OrderVersion>> (response, "response is List<OrderVersion>");
        }
        
        /// <summary>
        /// Test GetOrders
        /// </summary>
        [Test]
        public void GetOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> ids = null;
            //var response = instance.GetOrders(ids);
            //Assert.IsInstanceOf<List<Order>> (response, "response is List<Order>");
        }
        
        /// <summary>
        /// Test GetOwnedCommandReports
        /// </summary>
        [Test]
        public void GetOwnedCommandReportsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? masterid = null;
            //var response = instance.GetOwnedCommandReports(masterid);
            //Assert.IsInstanceOf<List<CommandReport>> (response, "response is List<CommandReport>");
        }
        
        /// <summary>
        /// Test GetOwnedCommandReportsBatch
        /// </summary>
        [Test]
        public void GetOwnedCommandReportsBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> masterids = null;
            //var response = instance.GetOwnedCommandReportsBatch(masterids);
            //Assert.IsInstanceOf<List<CommandReport>> (response, "response is List<CommandReport>");
        }
        
        /// <summary>
        /// Test GetOwnedCommands
        /// </summary>
        [Test]
        public void GetOwnedCommandsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? masterid = null;
            //var response = instance.GetOwnedCommands(masterid);
            //Assert.IsInstanceOf<List<Command>> (response, "response is List<Command>");
        }
        
        /// <summary>
        /// Test GetOwnedCommandsBatch
        /// </summary>
        [Test]
        public void GetOwnedCommandsBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> masterids = null;
            //var response = instance.GetOwnedCommandsBatch(masterids);
            //Assert.IsInstanceOf<List<Command>> (response, "response is List<Command>");
        }
        
        /// <summary>
        /// Test GetOwnedExecutionReports
        /// </summary>
        [Test]
        public void GetOwnedExecutionReportsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? masterid = null;
            //var response = instance.GetOwnedExecutionReports(masterid);
            //Assert.IsInstanceOf<List<ExecutionReport>> (response, "response is List<ExecutionReport>");
        }
        
        /// <summary>
        /// Test GetOwnedExecutionReportsBatch
        /// </summary>
        [Test]
        public void GetOwnedExecutionReportsBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> masterids = null;
            //var response = instance.GetOwnedExecutionReportsBatch(masterids);
            //Assert.IsInstanceOf<List<ExecutionReport>> (response, "response is List<ExecutionReport>");
        }
        
        /// <summary>
        /// Test GetOwnedFillFees
        /// </summary>
        [Test]
        public void GetOwnedFillFeesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? masterid = null;
            //var response = instance.GetOwnedFillFees(masterid);
            //Assert.IsInstanceOf<List<FillFee>> (response, "response is List<FillFee>");
        }
        
        /// <summary>
        /// Test GetOwnedFillFeesBatch
        /// </summary>
        [Test]
        public void GetOwnedFillFeesBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> masterids = null;
            //var response = instance.GetOwnedFillFeesBatch(masterids);
            //Assert.IsInstanceOf<List<FillFee>> (response, "response is List<FillFee>");
        }
        
        /// <summary>
        /// Test GetOwnedFills
        /// </summary>
        [Test]
        public void GetOwnedFillsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? masterid = null;
            //var response = instance.GetOwnedFills(masterid);
            //Assert.IsInstanceOf<List<Fill>> (response, "response is List<Fill>");
        }
        
        /// <summary>
        /// Test GetOwnedFillsBatch
        /// </summary>
        [Test]
        public void GetOwnedFillsBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> masterids = null;
            //var response = instance.GetOwnedFillsBatch(masterids);
            //Assert.IsInstanceOf<List<Fill>> (response, "response is List<Fill>");
        }
        
        /// <summary>
        /// Test GetOwnedOrderStrategies
        /// </summary>
        [Test]
        public void GetOwnedOrderStrategiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? masterid = null;
            //var response = instance.GetOwnedOrderStrategies(masterid);
            //Assert.IsInstanceOf<List<OrderStrategy>> (response, "response is List<OrderStrategy>");
        }
        
        /// <summary>
        /// Test GetOwnedOrderStrategiesBatch
        /// </summary>
        [Test]
        public void GetOwnedOrderStrategiesBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> masterids = null;
            //var response = instance.GetOwnedOrderStrategiesBatch(masterids);
            //Assert.IsInstanceOf<List<OrderStrategy>> (response, "response is List<OrderStrategy>");
        }
        
        /// <summary>
        /// Test GetOwnedOrderStrategyLinks
        /// </summary>
        [Test]
        public void GetOwnedOrderStrategyLinksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? masterid = null;
            //var response = instance.GetOwnedOrderStrategyLinks(masterid);
            //Assert.IsInstanceOf<List<OrderStrategyLink>> (response, "response is List<OrderStrategyLink>");
        }
        
        /// <summary>
        /// Test GetOwnedOrderStrategyLinksBatch
        /// </summary>
        [Test]
        public void GetOwnedOrderStrategyLinksBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> masterids = null;
            //var response = instance.GetOwnedOrderStrategyLinksBatch(masterids);
            //Assert.IsInstanceOf<List<OrderStrategyLink>> (response, "response is List<OrderStrategyLink>");
        }
        
        /// <summary>
        /// Test GetOwnedOrderStrategyLogs
        /// </summary>
        [Test]
        public void GetOwnedOrderStrategyLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? masterid = null;
            //var response = instance.GetOwnedOrderStrategyLogs(masterid);
            //Assert.IsInstanceOf<List<OrderStrategyLog>> (response, "response is List<OrderStrategyLog>");
        }
        
        /// <summary>
        /// Test GetOwnedOrderStrategyLogsBatch
        /// </summary>
        [Test]
        public void GetOwnedOrderStrategyLogsBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> masterids = null;
            //var response = instance.GetOwnedOrderStrategyLogsBatch(masterids);
            //Assert.IsInstanceOf<List<OrderStrategyLog>> (response, "response is List<OrderStrategyLog>");
        }
        
        /// <summary>
        /// Test GetOwnedOrderVersions
        /// </summary>
        [Test]
        public void GetOwnedOrderVersionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? masterid = null;
            //var response = instance.GetOwnedOrderVersions(masterid);
            //Assert.IsInstanceOf<List<OrderVersion>> (response, "response is List<OrderVersion>");
        }
        
        /// <summary>
        /// Test GetOwnedOrderVersionsBatch
        /// </summary>
        [Test]
        public void GetOwnedOrderVersionsBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> masterids = null;
            //var response = instance.GetOwnedOrderVersionsBatch(masterids);
            //Assert.IsInstanceOf<List<OrderVersion>> (response, "response is List<OrderVersion>");
        }
        
        /// <summary>
        /// Test GetOwnedOrders
        /// </summary>
        [Test]
        public void GetOwnedOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? masterid = null;
            //var response = instance.GetOwnedOrders(masterid);
            //Assert.IsInstanceOf<List<Order>> (response, "response is List<Order>");
        }
        
        /// <summary>
        /// Test GetOwnedOrdersBatch
        /// </summary>
        [Test]
        public void GetOwnedOrdersBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> masterids = null;
            //var response = instance.GetOwnedOrdersBatch(masterids);
            //Assert.IsInstanceOf<List<Order>> (response, "response is List<Order>");
        }
        
        /// <summary>
        /// Test InterruptOrderStrategy
        /// </summary>
        [Test]
        public void InterruptOrderStrategyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InterruptOrderStrategy body = null;
            //var response = instance.InterruptOrderStrategy(body);
            //Assert.IsInstanceOf<OrderStrategyStatusResponse> (response, "response is OrderStrategyStatusResponse");
        }
        
        /// <summary>
        /// Test LiquidatePosition
        /// </summary>
        [Test]
        public void LiquidatePositionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //LiquidatePosition body = null;
            //var response = instance.LiquidatePosition(body);
            //Assert.IsInstanceOf<PlaceOrderResult> (response, "response is PlaceOrderResult");
        }
        
        /// <summary>
        /// Test ModifyOrder
        /// </summary>
        [Test]
        public void ModifyOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ModifyOrder body = null;
            //var response = instance.ModifyOrder(body);
            //Assert.IsInstanceOf<CommandResult> (response, "response is CommandResult");
        }
        
        /// <summary>
        /// Test ModifyOrderStrategy
        /// </summary>
        [Test]
        public void ModifyOrderStrategyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ModifyOrderStrategy body = null;
            //var response = instance.ModifyOrderStrategy(body);
            //Assert.IsInstanceOf<OrderStrategyStatusResponse> (response, "response is OrderStrategyStatusResponse");
        }
        
        /// <summary>
        /// Test PlaceOCO
        /// </summary>
        [Test]
        public void PlaceOCOTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PlaceOCO body = null;
            //var response = instance.PlaceOCO(body);
            //Assert.IsInstanceOf<PlaceOcoResult> (response, "response is PlaceOcoResult");
        }
        
        /// <summary>
        /// Test PlaceOSO
        /// </summary>
        [Test]
        public void PlaceOSOTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PlaceOSO body = null;
            //var response = instance.PlaceOSO(body);
            //Assert.IsInstanceOf<PlaceOsoResult> (response, "response is PlaceOsoResult");
        }
        
        /// <summary>
        /// Test PlaceOrder
        /// </summary>
        [Test]
        public void PlaceOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PlaceOrder body = null;
            //var response = instance.PlaceOrder(body);
            //Assert.IsInstanceOf<PlaceOrderResult> (response, "response is PlaceOrderResult");
        }
        
        /// <summary>
        /// Test StartOrderStrategy
        /// </summary>
        [Test]
        public void StartOrderStrategyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //StartOrderStrategy body = null;
            //var response = instance.StartOrderStrategy(body);
            //Assert.IsInstanceOf<OrderStrategyStatusResponse> (response, "response is OrderStrategyStatusResponse");
        }
        
        /// <summary>
        /// Test SuggestExecutionReports
        /// </summary>
        [Test]
        public void SuggestExecutionReportsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string t = null;
            //int? l = null;
            //var response = instance.SuggestExecutionReports(t, l);
            //Assert.IsInstanceOf<List<ExecutionReport>> (response, "response is List<ExecutionReport>");
        }
        
    }

}
