// Innovace Intech Solution Pvt Ltd
import React, { useState } from "react";
import { useNavigate } from "react-router-dom";

type Errors = Partial<Record<string, string>>;

const CreateAccount: React.FC = () => {
  const navigate = useNavigate();

  const [form, setForm] = useState({
    vendorCode: "",
    firstName: "",
    lastName: "",
    gender: "Male",
    email: "",
    mobile: "",
    otp: "",
  });

  const [errors, setErrors] = useState<Errors>({});
  const [isSubmitting, setIsSubmitting] = useState(false);

  const handleChange =
    (field: keyof typeof form) =>
    (e: React.ChangeEvent<HTMLInputElement | HTMLSelectElement>) => {
      setForm({ ...form, [field]: e.target.value });
      setErrors((prev) => ({ ...prev, [field]: "" }));
    };

  // ✅ Validation
  const validate = (): boolean => {
    const newErrors: Errors = {};

    if (!form.vendorCode) newErrors.vendorCode = "Vendor code is required";
    if (!form.firstName) newErrors.firstName = "First name is required";
    if (!form.lastName) newErrors.lastName = "Last name is required";

    if (!form.email) {
      newErrors.email = "Email is required";
    } else if (!/^\S+@\S+\.\S+$/.test(form.email)) {
      newErrors.email = "Invalid email address";
    }

    if (!form.mobile) {
      newErrors.mobile = "Mobile number is required";
    } else if (!/^\d{10}$/.test(form.mobile)) {
      newErrors.mobile = "Enter valid 10-digit mobile number";
    }

    if (!form.otp) newErrors.otp = "OTP is required";

    setErrors(newErrors);
    return Object.keys(newErrors).length === 0;
  };

  // ✅ Submit
  const handleSubmit = async () => {
    if (!validate()) return;

    setIsSubmitting(true);

    try {
      // 🔗 API call goes here later
    

      // success demo
      alert("Account created successfully");
      navigate("/login");
    } catch (error) {
      alert("Something went wrong");
    } finally {
      setIsSubmitting(false);
    }
  };

  return (
   
      <div
        className="d-flex justify-content-center align-items-center vh-100"
        style={{ backgroundColor: "#f3f3f3" }}
      >
        <div
          className="card border-0 shadow"
          style={{ maxWidth: 460, width: "100%", borderRadius: 12, padding: 28 }}
        >
          <div className="text-center mb-3">
            <img src="data:image/png;base64,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" height={36} />
          </div>

          <h5 className="fw-bold text-center mb-1">Create your account</h5>
          <p className="text-muted text-center mb-4" style={{ fontSize: 13 }}>
            Enter your personal details to create account
          </p>

          {/* Vendor Code */}
          <div className="mb-3">
            <label className="form-label small fw-semibold">Vendor Code</label>
            <input
              className={`form-control ${errors.vendorCode ? "is-invalid" : ""}`}
              value={form.vendorCode}
              onChange={handleChange("vendorCode")}
            />
            <div className="invalid-feedback" style={{marginTop:"-10px", marginLeft:"10px", backgroundColor:"#fff", width:"fit-content"}}>{errors.vendorCode}</div>
          </div>

          {/* Name */}
          <div className="row mb-3">
            <div className="col">
              <label className="form-label small fw-semibold">First Name</label>
              <input
                className={`form-control ${errors.firstName ? "is-invalid" : ""}`}
                value={form.firstName}
                onChange={handleChange("firstName")}
              />
              <div className="invalid-feedback" style={{marginTop:"-10px", marginLeft:"10px", backgroundColor:"#fff", width:"fit-content"}}>{errors.firstName}</div>
            </div>
            <div className="col">
              <label className="form-label small fw-semibold">Last Name</label>
              <input
                className={`form-control ${errors.lastName ? "is-invalid" : ""}`}
                value={form.lastName}
                onChange={handleChange("lastName")}
              />
              <div className="invalid-feedback" style={{marginTop:"-10px", marginLeft:"10px", backgroundColor:"#fff", width:"fit-content"}}>{errors.lastName}</div>
            </div>
          </div>

          {/* Gender */}
          <div className="mb-3">
            <label className="form-label small fw-semibold">Gender</label>
            <select
              className="form-select"
              value={form.gender}
              onChange={handleChange("gender")}
            >
              <option>Male</option>
              <option>Female</option>
              <option>Other</option>
            </select>
          </div>

          {/* Email */}
          <div className="mb-3">
            <label className="form-label small fw-semibold">Email</label>
            <input
              type="email"
              className={`form-control ${errors.email ? "is-invalid" : ""}`}
              value={form.email}
              onChange={handleChange("email")}
            />
            <div className="invalid-feedback" style={{marginTop:"-10px", marginLeft:"10px", backgroundColor:"#fff", width:"fit-content"}}>{errors.email}</div>
          </div>

          {/* Mobile */}
          <div className="mb-3">
            <label className="form-label small fw-semibold">Mobile Number</label>
            <input
              className={`form-control ${errors.mobile ? "is-invalid" : ""}`}
              value={form.mobile}
              onChange={handleChange("mobile")}
            />
            <div className="invalid-feedback" style={{marginTop:"-10px", marginLeft:"10px", backgroundColor:"#fff", width:"fit-content"}}>{errors.mobile}</div>
          </div>

          {/* OTP */}
          <div className="row mb-4">
            <div className="col-5">
              <button
                type="button"
                className="btn w-100 text-white"
                style={{ backgroundColor: "#000" }}
              >
                Send OTP
              </button>
            </div>
            <div className="col">
              <label className="form-label small fw-semibold">Enter OTP</label>
              <input
                className={`form-control ${errors.otp ? "is-invalid" : ""}`}
                value={form.otp}
                onChange={handleChange("otp")}
              />
              <div className="invalid-feedback" style={{marginTop:"-10px", marginLeft:"10px", backgroundColor:"#fff", width:"fit-content"}}>{errors.otp}</div>
            </div>
          </div>

          {/* Submit */}
          <button
            disabled={isSubmitting}
            onClick={handleSubmit}
            className="btn w-100 text-white fw-semibold mb-3"
            style={{ backgroundColor: "#000", height: 44 }}
          >
            {isSubmitting ? "Submitting..." : "Submit"}
          </button>

          <div className="text-center small">
            Already have an account?{" "}
            <span
              className="fw-semibold"
              style={{ cursor: "pointer" }}
              onClick={() => navigate("/login")}
            >
              Sign in
            </span>
          </div>
        </div>
      </div>
   
  );
};

export default CreateAccount;
