 

<!doctype html>
<html>
<head>

    <title>Paid By Us Transactions Table</title>

    <script src="~/Scripts/jquery-3.1.1.min.js"></script>

    <script>
        $(document).ready(function () {

                $('#OriginalCurrencySelect').on('change', function (e) {
                var optionSelected = $("option:selected", this);
                var valueSelected = this.value;
                $('#OriginalCurrencyAddon').text(valueSelected);
                $('#OriginalAmountAddon').text(valueSelected);
                
                });

                $('#BillingCurrencySelect').on('change', function (e) {
                    var optionSelected = $("option:selected", this);
                    var valueSelected = this.value;
                    $('#BillingCurrencyAddon').text(valueSelected);
                    $('#BillingAmountAddon').text(valueSelected);


                });

        })
    </script>

</head>
<body>
    
    <div class="container">
        <form style="margin-top:20px">
            <fieldset>
                <legend class="text-center">Add New Transaction</legend>

                <div class="row form-group">
                    <div class="col-lg-3 col-lg-offset-3">
                        <label for="OriginalAmount">Original Amount</label>
                        <div class="input-group">
                            <div class="input-group-addon" id="OriginalAmountAddon">$</div>
                            <input type="text" class="form-control" id="OriginalAmount" placeholder="Amount">
                        </div>
                    </div>

                    <div class="col-lg-3">
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
                    <div class="col-lg-3 col-lg-offset-3">
                        <label for="BillingAmount">Billing Amount</label>
                        <div class="input-group">
                            <div class="input-group-addon" id="BillingAmountAddon">$</div>
                            <input type="text" class="form-control" id="BillingAmount" placeholder="Amount">
                        </div>
                    </div>

                    <div class="col-lg-3">
                        <label for="BillingCurrencySelect">Billing Currency Code</label>
                        <div class="input-group">
                            <div class="input-group-addon" id="BillingCurrencyAddon">$</div>
                            <select class="form-control" id="BillingCurrencySelect">
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
                        <label for="Status">Supplier Name</label>
                        <input type="text" class="form-control" id="SupplierName" placeholder="Name">
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

                    <div class="form-group col-lg-3">
                        <label for="Status">Trip Number</label>
                        <input type="email" class="form-control" id="TripNumber" placeholder="Trip Number">
                    </div>
                </div>

                <div class="row form-group">
                    <div class="form-group col-lg-offset-3 col-lg-3">
                        <label for="CreatedBy">Created By</label>
                        <input type="email" class="form-control" id="CreatedBy" placeholder="Created By" disabled>
                    </div>

                    <div class="form-group col-lg-3">
                        <label for="CreatedDate">Created Date</label>
                        <input type="email" class="form-control" id="CreatedDate" placeholder="Created Date" disabled>
                    </div>
                </div>

                <div class="row form-group">
                    <div class="form-group col-lg-offset-3 col-lg-3">
                        <label for="ModifiedBy">Modified By</label>
                        <input type="email" class="form-control" id="ModifiedBy" placeholder="Modified By" disabled>
                    </div>

                    <div class="form-group col-lg-3">
                        <label for="ModifiedDate">Modified Date</label>
                        <input type="email" class="form-control" id="ModifiedDate" placeholder="Modified Date" disabled>
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