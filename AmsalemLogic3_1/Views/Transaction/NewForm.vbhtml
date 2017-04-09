@Code
    ViewData("Title") = "View"
    Dim trip = ViewBag.trip
    Dim BackOfficeCompany = String.Empty
    If (trip IsNot Nothing) Then
        BackOfficeCompany = trip.AxCompany
    Else
        'BackOfficeCompany = DirectCast(ViewBag.user, ClassUsers).AxCompany
        BackOfficeCompany = ViewBag.user.AxCompany
    End If
End Code


<!doctype html>
<html>
<head>

    <title>Paid By Us Transactions Table</title>
    <span>@BackOfficeCompany</span>
    <link href="~/Content/toastr.css" rel="stylesheet" />
    <script src="~/Scripts/jquery-3.1.1.min.js"></script>
    <script src="~/Scripts/toastr.js"></script>
    <script>
        $(document).ready(function () {

            $("#NewTransaction").validate({

                rules: {
                    tripNumber: {
                        required: true
                    }
                },

                submitHandler: function(form)
                {
                $.ajax({
                    url: '/Transaction/Create',
                    data: $("#NewTransaction").serialize(),
                    type: 'POST',
                    success: function (data) {
                        if (data.Message == "Success")
                        {
                            id = 6;
                            window.location = '/Transaction/Details/' + id;
                        }
                        else {
                            toastr.error(data.Message);

                        }


                    }
                });
              }

            });

                $('#OriginalCurrencySelect').on('change', function (e) {
                var optionSelected = $("option:selected", this);
                var valueSelected = this.value;
                $('#OriginalCurrencyAddon').text(valueSelected);
                $('#OriginalAmountAddon').text(valueSelected);

                });

        })
    </script>

</head>
<body>

    <div class="container">
        <form style="margin-top:20px" id="NewTransaction">
            <fieldset>
                <legend class="text-center">Add New Transaction</legend>

                <div class="row form-group">
                    <div class="form-group col-lg-3 col-lg-offset-3">
                        <label for="OriginalAmount">Original Amount</label>
                        <div class="input-group">
                            <div class="input-group-addon" id="OriginalAmountAddon">$</div>
                            <input type="text" class="form-control" id="OriginalAmount" placeholder="Amount">
                        </div>
                    </div>

                    <div class="form-group col-lg-3">
                        <label for="OriginalCurrencySelect">Original Currency Code</label>
                        <div class="input-group">
                            <div class="input-group-addon" id="OriginalCurrencyAddon">$</div>
                            <select class="form-control" id="OriginalCurrencySelect">
                                <option value="$">USD</option>
                                <option value="€">EUR</option>
                                <option value="£">GBP</option>
                                <option value="₪">ILS</option>
                            </select>
                        </div>
                    </div>

                </div>

                <div class="row form-group">
                    <div class="col-lg-offset-3 col-lg-3">
                        <label for="TripNumber">Trip Number</label>
                        <input name="tripNumber" type="text" class="form-control" id="TripNumber" placeholder="Trip Number">
                    </div>

                    <div class="form-group col-lg-3">
                        <label for="SupplierAccount">Supplier Account</label>
                        <input type="email" class="form-control" id="SupplierAccount" placeholder="Supplier">
                    </div>
                </div>

                <div class="row form-group">
                    <div class="form-group col-lg-offset-3 col-lg-3">
                        <label for="BackOfficeCompany">Back Office Company</label>
                        <select class="form-control" id="BackOfficeCompany">
                            <option value="1">AMSA1</option>
                            <option value="2">AMSA2</option>
                            <option value="3">AMSA3</option>
                            <option value="4">AMSA4</option>
                        </select>
                    </div>

                    
                </div>

                <div class="row form-group">

                    <div class="form-group col-lg-offset-3 col-lg-3">

                        <label for="For">For</label>
                        <input type="text" class="form-control" id="For" placeholder="For Who">

                    </div>

                    <div class="form-group col-lg-3">

                        <label for="Item">Item</label>
                        <input type="text" class="form-control" id="Item" placeholder="Item">

                    </div>

                </div>

                <div class="row form-group">
                    <button type="submit" class="btn btn-success form-group col-lg-offset-3 col-lg-6">Get Card</button>
                </div>

            </fieldset>

        </form>
    </div>
</body>
</html>