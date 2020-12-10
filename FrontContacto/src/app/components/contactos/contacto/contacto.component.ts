import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ContactoModel } from 'src/app/models/contactoModel';
import { ContactoService } from 'src/app/services/contacto.service';
import { GooglePlaceModule } from 'ngx-google-places-autocomplete'

@Component({
  selector: 'app-contacto',
  templateUrl: './contacto.component.html',
  styleUrls: ['./contacto.component.css'],
})

export class ContactoComponent implements OnInit {

  form: FormGroup;

  constructor(private formBuilder: FormBuilder, private contactoService: ContactoService) { 
    this.form = this.formBuilder.group({
      id: 0,
      nombre: ['',[Validators.required]],
      email: ['',[Validators.required,Validators.email]],
      telefono: ['',[Validators.required]],
      fecha: ['',[Validators.required]],
      direccion: ['',[Validators.required]]

    })
  }

  
  formattedAdres = '';

  options = {
    componentRestrictions : {
      
    }
  }

  public  handleAddressChange ( address : any )  { 
    this.formattedAdres = address.formatted_address;
  }

  ngOnInit(): void {
    imports: [GooglePlaceModule]
  }

  guardarContacto(){
    const contacto: ContactoModel = {
      nombre: this.form.get('nombre')?.value,
      email: this.form.get('email')?.value,
      telefono: this.form.get('telefono')?.value,
      fecha: this.form.get('fecha')?.value,
      direccion: this.form.get('direccion')?.value
    }
    this.contactoService.guardarContacto(contacto).subscribe(data => {
      console.log('Guardado Exitosamente');
      this.form.reset();
    });

  }

}
