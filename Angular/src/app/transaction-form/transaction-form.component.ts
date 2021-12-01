import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { UserService } from '../Services/user.service';
import {Transaction} from '../Models/Transaction';

@Component({
  selector: 'app-transaction-form',
  templateUrl: './transaction-form.component.html',
  styleUrls: ['./transaction-form.component.css']
})
export class TransactionFormComponent implements OnInit {

  constructor(private service: UserService, private router: Router, private toastr: ToastrService) { }
  transactionResponse:any;
  transaction = new  Transaction();
  ngOnInit() {
  }
  onLogout() {
    localStorage.removeItem('token');
    this.router.navigate(['/user/login']);
  }
  onSubmit(form: NgForm) {
    this.service.SubmitForm(form.value).subscribe(
      (res: any) => {
        this.transactionResponse = res;
      },
      err => {
        if (err.status == 500)
          this.toastr.error('Incorrect Data', 'Data Error');
        else
          console.log(err);
      }
    );
  }
}
