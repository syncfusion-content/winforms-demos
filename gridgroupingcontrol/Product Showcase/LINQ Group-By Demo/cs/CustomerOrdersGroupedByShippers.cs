﻿# region Directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using System.Collections;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;

#endregion

namespace LinqGroupBy
{
    class CustomerOrdersGroupedByShippers : SampleQuery
    {
        # region Variable Declaration

        NorthwindwithImage db;

        #endregion

        # region Method

        # region Override Method

        public override void InitializeGrid(GridGroupingControl grid, NorthwindwithImage db)
        {
            this.db = db;

            var customerQuery = from customer in db.Customers
                                group customer by customer.Country into g
                                select new
                                {
                                    Key = g.Key,
                                    Count = g.Count(),
                                    //Details = g
                                };

            var customerTotals = customerQuery.Count();

            // Pass in a sample query for determing optimal column widths.
            // Use this together with GridColumnsMaxLengthStrategy.FirstNRecords
            var customerSampleQuery = from c in db.Customers
                                      select c;

            PassThroughGroupingResult customerQueryResults = new PassThroughGroupingResult(
                    "Customer",
                    customerQuery,
                    typeof(Customers),
                    customerTotals,
                    new QueryGroupsDetailsDelegate(GetDetailsForCountry),
                    customerSampleQuery.Take(10),
                    "Country"
                    );

            var orderSampleQuery =  from p in db.Orders
                                    select p;

            PassThroughGroupingResult orderResults = new PassThroughGroupingResult(
                    "Orders",
                    new NestedQueryResultsDelegate(this.GetOrdersForCustomerGroupedByShippers),
                    typeof(Orders),
                    new QueryGroupsDetailsDelegate(GetDetailsForOrders),
                    orderSampleQuery.Take(10),
                    "Shipper_CompanyName"
                    );

            grid.SourceListSet.Add("Customer", customerQueryResults);
            grid.SourceListSet.Add("Orders", orderResults);
           
            grid.DataSource = customerQueryResults;

            // Clear out otherwise autopopulated UniformChildList relations
            // for Orders and CustomerCustomerDemos.
            grid.TableDescriptor.Relations.Clear();

            GridRelationDescriptor orders = new GridRelationDescriptor("Orders");
            orders.RelationKeys.Add("CustomerID", "CustomerID");
            orders.ChildTableName = "Orders";
            orders.RelationKind = RelationKind.RelatedMasterDetails;
            orders.ChildTableDescriptor.Relations.Clear();

            grid.TableDescriptor.Relations.Add(orders);

            // Question: When consumer of customerQuery accesses nested lists such as Orders
            // will Linq fire a separate select statement or will they already
            // be in memory?

            grid.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;

            grid.TableDescriptor.Columns["CompanyName"].HeaderText = "Company Name";
            grid.TableDescriptor.Columns["ContactName"].HeaderText = "Contact Name";
            grid.TableDescriptor.Columns["ContactTitle"].HeaderText = "Contact Title";
            grid.TableDescriptor.Columns["CustomerID"].HeaderText = "Customer ID";
            grid.TableDescriptor.Columns["PostalCode"].HeaderText = "Postal Code";
            //grid.TableDescriptor.Columns["RequiredDate"].HeaderText = "Contact Title";
           // grid.TableDescriptor.Columns["OrderedDate"].HeaderText = "Customer ID";
          //  grid.TableDescriptor.Columns["ShippedCountry"].HeaderText = "Shipped Country";
           // grid.TableDescriptor.Columns["ShipName"].HeaderText = "Ship Name";




            foreach (GridTableDescriptor td in grid.Engine.EnumerateTableDescriptor())
            {
                if (td.Name == "Orders")
                {
                    td.Columns["OrderID"].HeaderText = "Order ID";
                    td.Columns["ShipName"].HeaderText = "ShipName";
                    td.Columns["ShipAddress"].HeaderText = "Ship Address";
                    td.Columns["EmployeeID"].HeaderText = "Employee ID";
                    td.Columns["OrderDate"].HeaderText = "Order Date";
                    td.Columns["RequiredDate"].HeaderText = "Required Date";
                    td.Columns["ShippedDate"].HeaderText = "Shipped Date";
                    td.Columns["ShipCity"].HeaderText = "Ship City";
                    td.Columns["ShipCountry"].HeaderText = "Ship Country";
                    td.Columns["ShipRegion"].HeaderText = "Ship Region";
                    td.Columns["ShipPostalCode"].HeaderText = "Ship Postal Code";
                  
                }
            }

            grid.TableModel.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            grid.Table.TableOptions.RecordRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);
            grid.Table.TableOptions.ColumnHeaderRowHeight = (int)DpiAware.LogicalToDeviceUnits(26.0f);
            grid.Table.TableOptions.CaptionRowHeight = (int)DpiAware.LogicalToDeviceUnits(22.0f);

        }

        #endregion

        # region Public Method

        public IEnumerable GetDetailsForCountry(Group group)
        {
            // If group is nested, you also need to filter with CategoryKeys from g.ParentGroup!
            string country = (string) PassThroughGroupingResult.GetValue(group.PassThroughItem, "Key");

            // TODO: If country is null find a way to query for it more efficiently ...
            if (country == null)
            {
                return
                    from p in db.Customers
                    where !(p.Country != null)
                    select p;
            }

            var query =
                from p in db.Customers
                where p.Country == country
                select p
                ;

            return query;
        }

        public IEnumerable GetOrdersForCustomerGroupedByShippers(object[] keys, out object totals)
        {
            var orderQuery =
                from p in db.Orders
                where p.CustomerID.Equals(keys[0])
                group p by p.ShipAddress into g
                select new
                {
                   // Caption = g.Key..CompanyName,
                    Key = g.Key,
                    Count = g.Count(),
                  
                };

            totals = (from p in db.Orders
                      where p.CustomerID.Equals(keys[0])
                      group p by 0 into g
                      select new
                      {
                          CustomerID = keys[0],
                          Count = g.Count(),
                      })
                      .Single();

            return orderQuery;
        }

        public IEnumerable GetDetailsForOrders(Group group)
        {
            int? shipperID = (int?) PassThroughGroupingResult.GetValue(group.PassThroughItem, "Key.ShipperID");
            
            string customerID = (string) PassThroughGroupingResult.GetValue(group.ParentChildTable.PassThroughItem, "CustomerID");

            var orderQuery =
                from p in db.Orders
                where p.CustomerID.Equals(customerID)
                && p.ShipVia == shipperID
                select p
                ;

            return orderQuery;
        }

        #endregion

        #endregion

    }
}
