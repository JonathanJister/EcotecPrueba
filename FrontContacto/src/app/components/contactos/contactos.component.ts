import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-contactos',
  templateUrl: './contactos.component.html',
  styleUrls: ['./contactos.component.css']
})
export class ContactosComponent implements OnInit {

  constructor() { }

  formattedAdres = '';

  options = {
    componentRestrictions : {
      country: ['MX']
    }
  }

  public  handleAddressChange ( address : any )  { 
    this.formattedAdres = address.formatted_address;
  }

  ngOnInit(): void {
  }

}
