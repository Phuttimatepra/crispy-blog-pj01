import { Component, OnInit } from '@angular/core';
import { FirstTimesService } from 'src/app/_services/first-times.service';
import { Member } from 'src/app/_models/Member';

@Component({
  selector: 'app-first-times',
  templateUrl: './first-times.component.html',
  styleUrls: ['./first-times.component.css']
})
export class FirstTimesComponent implements OnInit {

  constructor(
    public firstTimeService : FirstTimesService
  ) { }

  ngOnInit(): void {
  }

  username : string
  password : string
  email : string

  // variable is Model
  member : Member

  registerClick(user : HTMLInputElement, pass : HTMLInputElement, mail : HTMLInputElement){

    debugger;

    let obj = {
      "MemberID" : 0,
      "Username" : user.value,
      "Password" : pass.value,
      "Email" : mail.value
    }

    this.member = Object.assign({}, Member, obj)

    this.postUserInfo(this.member)
  }

  postUserInfo(member : Member){
    this.firstTimeService.insertDataAll(member).subscribe()
  }

}
