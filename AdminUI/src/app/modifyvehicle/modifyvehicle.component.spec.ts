import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModifyvehicleComponent } from './modifyvehicle.component';

describe('ModifyvehicleComponent', () => {
  let component: ModifyvehicleComponent;
  let fixture: ComponentFixture<ModifyvehicleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ModifyvehicleComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ModifyvehicleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
