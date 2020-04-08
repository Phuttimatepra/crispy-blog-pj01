import { Component, OnInit } from '@angular/core';
import { Member } from 'src/app/_models/Member';
import { RegisterAccService } from 'src/app/_services/register-acc.service';

@Component({
  selector: 'app-register-acc',
  templateUrl: './register-acc.component.html',
  styleUrls: ['./register-acc.component.css']
})
export class RegisterAccComponent implements OnInit {

  // Variable
  usernameData: string
  emailData: string
  passwordData: string
  cfpasswordData: string

  constructor(
    public registerAccService: RegisterAccService
  ) { }

  ngOnInit(): void {
  }

  member: Member

  sentRegister(user: HTMLInputElement, mail: HTMLInputElement, pass: HTMLInputElement, cfpass: HTMLInputElement) {
    console.log("ABC");
    console.log(this.passwordData);

    // validate password and confirm password ==========

    // =================================================

    // === session ====
    let key = 'item1'
    let a = localStorage.setItem(key, 'value')
    console.log("show localstorage", a);
    

    // ================

    let obj = {
      "MemberID": 0,
      "Username": user.value,
      "Password": pass.value,
      "Email": mail.value
    }

    this.member = Object.assign({}, Member, obj)

    this.postProfileAcc(this.member)
  }

  // func. to call service to call api
  postProfileAcc(member: Member) {
    this.registerAccService.insertProfileAcc(member).subscribe();
  }
}
