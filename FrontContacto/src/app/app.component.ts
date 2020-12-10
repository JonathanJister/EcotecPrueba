import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'FrontContacto';
  formattedAdres = '';

  options = {
    componentRestrictions : {
      country: ['MX']
    }
  }

  

  public  handleAddressChange ( address : any )  { 
    this.formattedAdres = address.formatted_address;
  }

}

