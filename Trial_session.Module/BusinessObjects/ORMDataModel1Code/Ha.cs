﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Trial_session.Module.BusinessObjects.ORMDataModel1
{

    public partial class Ha
    {
        public Ha(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}