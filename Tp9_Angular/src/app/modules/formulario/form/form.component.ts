import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ShipersService } from '../service/shippers.service';
import { Shippers } from '../shippers';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.scss']
})
export class FormComponent implements OnInit {

  public formShippers: FormGroup;
  private shipperId: number = 0;

  get f(){
    return this.formShippers.controls;
  }

  constructor(
    private formBuilder: FormBuilder,
    private service: ShipersService,
    private router: Router,
    private activatedRoute: ActivatedRoute){
      this.formShippers = this.formBuilder.group({
        id: undefined,
        name: ['',[Validators.required, Validators.maxLength(40)]],
        phone: ['',[Validators.required, Validators.maxLength(24)]]
      });
  }

  ngOnInit(): void {
    this.activatedRoute.queryParams.subscribe(p =>{
      this.shipperId = p['Id']
    });
    if(this.shipperId > 0){
      this.service.getShippersId(this.shipperId).subscribe(r =>{
        this.formShippers.setValue({
          id: r.ID,
          name: r.Name,
          phone: r.Phone
        });
      });
    }
  }

  onSubmit(): void{
    var name = this.formShippers.get('name');
    var phone = this.formShippers.get('phone');
    if(name != null && phone != null){
      var shippers = new Shippers(name.value, phone.value);
      if(this.shipperId > 0){
        shippers.ID = this.formShippers.get('id')?.value;
        this.service.updateShippers(this.shipperId, shippers).subscribe(r =>{
          this.router.navigateByUrl('');
        });
      } 
      else{
        this.service.postShippers(shippers).subscribe(r=>{
          this.router.navigateByUrl('');
        });
      }
    }
  }
}


