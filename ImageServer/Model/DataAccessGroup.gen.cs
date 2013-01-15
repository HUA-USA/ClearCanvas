#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model
{
    using System;
    using System.Xml;
    using ClearCanvas.Enterprise.Core;
    using ClearCanvas.ImageServer.Enterprise;
    using ClearCanvas.ImageServer.Model.EntityBrokers;

    [Serializable]
    public partial class DataAccessGroup: ServerEntity
    {
        #region Constructors
        public DataAccessGroup():base("DataAccessGroup")
        {}
        public DataAccessGroup(
             ServerEntityKey _authorityGroupOID_
            ,Boolean _deleted_
            ):base("DataAccessGroup")
        {
            AuthorityGroupOID = _authorityGroupOID_;
            Deleted = _deleted_;
        }
        #endregion

        #region Public Properties
        [EntityFieldDatabaseMappingAttribute(TableName="DataAccessGroup", ColumnName="AuthorityGroupOID")]
        public ServerEntityKey AuthorityGroupOID
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="DataAccessGroup", ColumnName="Deleted")]
        public Boolean Deleted
        { get; set; }
        #endregion

        #region Static Methods
        static public DataAccessGroup Load(ServerEntityKey key)
        {
            using (var read = PersistentStoreRegistry.GetDefaultStore().OpenReadContext())
            {
                return Load(read, key);
            }
        }
        static public DataAccessGroup Load(IPersistenceContext read, ServerEntityKey key)
        {
            var broker = read.GetBroker<IDataAccessGroupEntityBroker>();
            DataAccessGroup theObject = broker.Load(key);
            return theObject;
        }
        static public DataAccessGroup Insert(DataAccessGroup entity)
        {
            using (var update = PersistentStoreRegistry.GetDefaultStore().OpenUpdateContext(UpdateContextSyncMode.Flush))
            {
                DataAccessGroup newEntity = Insert(update, entity);
                update.Commit();
                return newEntity;
            }
        }
        static public DataAccessGroup Insert(IUpdateContext update, DataAccessGroup entity)
        {
            var broker = update.GetBroker<IDataAccessGroupEntityBroker>();
            var updateColumns = new DataAccessGroupUpdateColumns();
            updateColumns.AuthorityGroupOID = entity.AuthorityGroupOID;
            updateColumns.Deleted = entity.Deleted;
            DataAccessGroup newEntity = broker.Insert(updateColumns);
            return newEntity;
        }
        #endregion
    }
}