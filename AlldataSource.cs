using plths.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plths
{
    class AlldataSource
    {

        private plthsEntities.Entities.plthsEntities _context = new plthsEntities.Entities.plthsEntities();
        Guna.UI.WinForms.GunaComboBox _cmb;
        Guna.UI.WinForms.GunaDataGridView _grid;
        int iid;

        public void eleComponet(Guna.UI.WinForms.GunaComboBox cmb)
        {
            _cmb = cmb;
        }

        public void gridComponent(Guna.UI.WinForms.GunaDataGridView grid)
        {
            _grid = grid;
        }
        
        public void gridBorrower(Guna.UI.WinForms.GunaDataGridView grid, int itemid)
        {
            _grid = grid;
            iid = itemid;
        }

        public void purokGridList()
        {
            var purokList = (

                from r in _context.Puroks
                where r.pstatus == "active"
                //join p in _context.Puroks
                //on r.PurokID equals p.Purok_Id

                select new ViewModelPurok
                {
                    Purok_Id = r.Purok_Id,
                    PurokName = r.Purok_Nane,
                    PurokLeader = r.Purok_Leader,
                    Contact = r.Contact,
                    Status = r.pstatus

                }

              ).ToList();


            _cmb.DataSource = purokList;

           

        }


        public void itemGridList()
        {
            var list = 
                (
                from i in _context.inventories
                where i.itemStatus.Contains("active")


                select new InventoryViewModel
                {
                    id = i.itemID,
                    name = i.itemName,
                    quantity = i.quantity,
                    borrowed = (int)i.borrowed_quan
                    
                }
                ).ToList();

            _grid.DataSource = list;
        }

        public void borrowerGridList()
        {
            var list =
                (
                from b in _context.borroweds
                join i in _context.inventories
                on b.itemid equals i.itemID
                where b.itemid == iid

                select new ViewModelBorrowers
                {
                    borrowid = b.borrowID,
                    borrowedquantity = b.num_borrowed,
                    borrower = b.borrower,
                    itemid = b.itemid,
                    itemname = i.itemName

                }
                ).ToList();

            _grid.DataSource = list;
        }

        //public void residentGridList()
        //{
        //    var residentList = (

        //        from r in _context.Residents
        //        join p in _context.Puroks
        //        on r.PurokID equals p.Purok_Id
        //        where r.dataStatus == "active"

        //        select new ViewModelResident
        //        {
        //            resid = r.ID,
        //            fn = r.Firstname,
        //            mn = r.Middlename,
        //            ln = r.Lastname,
        //            fullname = r.fullname,
        //            bod = (DateTime)r.Birthdate,
        //            age = (int)r.Age,
        //            gender = r.Gender,
        //            cstat = r.civil_status,
        //            lstat = r.status,
        //            address = r.Adress,
        //            prkid = (int)r.PurokID,
        //            purokname = p.Purok_Nane,
        //            citizenship = r.Citizenship,
        //            religion = r.Religion,
        //            email = r.Email,
        //            mobile = r.Mobile,
        //            voterid = r.Voter_id,
        //            precinct = r.Precint_No,
        //            education = r.e_attainment,
        //            profession = r.Profession,
        //            dialect = r.Dialect,
        //            fnfather = r.F_Fname,
        //            mnfather = r.F_Mname,
        //            lnfather = r.F_Lname,
        //            fullfathername = r.father_fullname,
        //            fnmother = r.M_Finame,
        //            mnmother = r.M_Mname,
        //            lnmother = r.M_Lname,
        //            fullmothername = r.mother_fullname,
        //            benefeciary = r.beneficiary
        //        }

        //      ).ToList();


        //    orcmb.DataSource = residentList;



        //}


    }



}
