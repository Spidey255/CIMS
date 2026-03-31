// Innovace Intech Solution Pvt Ltd
import React, { useState } from "react";
import axiosHelper from "../../../helpers/axiosHelper";
import { useUserStore } from "../../../store/useUserStore";
import type { IOnActionResponse } from "../../../constants/types";
import { useNavigate } from "react-router-dom";
import { config } from "../../../constants/config";

const Login: React.FC = () => {
  const [credentials, setCredentials] = useState({
    userName: "",
    password: "",
    remoteUrl: "0",
  });

  const [showPassword, setShowPassword] = useState(false);
  const [isSubmitting, setIsSubmitting] = useState(false);
  const [error, setError] = useState<string | null>(null);

  const navigate = useNavigate();
  const setSlotId = useUserStore((store) => store.setSlotId);
  const setIsAuthenticating = useUserStore((store) => store.setIsAuthenticated);
  const setStoreError = useUserStore((store) => store.setError);

  const handleChange =
    (field: "userName" | "password") =>
      (event: React.ChangeEvent<HTMLInputElement>) => {
        setCredentials((prev) => ({ ...prev, [field]: event.target.value }));
      };

  const authenticateUser = async (
    event: React.FormEvent<HTMLFormElement>
  ): Promise<void> => {
    event.preventDefault();

    if (!credentials.userName || !credentials.password) {
      const message = "Username and password are required.";
      setError(message);
      setStoreError(message);
      return;
    }

    setIsSubmitting(true);
    setIsAuthenticating(true);
    setError(null);
    setStoreError(null);

    try {
      const response = await axiosHelper<IOnActionResponse>(
        config.AUTH_URL,
        "POST",
        JSON.stringify({
          userName: credentials.userName,
          password: credentials.password,
          forceLogin: false,
          slotId: null,
          RemoteUrl: credentials.remoteUrl,
        }),
        {
          "Content-Type": "application/json",
        }
      );

      const slotToken = response?.Token;

      if (!slotToken) {
        throw new Error(response?.Message || "Authentication failed.");
      }

      sessionStorage.setItem("accessToken", slotToken);
      localStorage.setItem("token", slotToken);
       localStorage.setItem("displayName", response?.TokenDetail?.displayName || '');
      localStorage.setItem("roleNames", response?.TokenDetail?.roleNames || '');
      setSlotId(slotToken);
      navigate("/");
    } catch (err) {
      const message =
        typeof err === "object" && err !== null && "message" in err
          ? (err as { message?: string }).message ||
          "Unable to login. Please try again."
          : "Unable to login. Please try again.";

      setError(message);
      setStoreError(message);
    } finally {
      setIsSubmitting(false);
      setIsAuthenticating(false);
    }
  };

  return (
    <div
      className="d-flex justify-content-center align-items-center vh-100"
      style={{ backgroundColor: "#f3f3f3" }}
    >
      <div
        className="card border-0 shadow"
        style={{
          width: "100%",
          maxWidth: 420,
          borderRadius: 12,
          padding: "28px",
        }}
      >
        {/* Logo */}
        <div className="text-center mb-3 digivista">
          {/* <img
            src="data:image/png;base64,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" // replace with your actual logo path
            alt="Vertiv Digivista"
            style={{ height: 36 }}
          /> */}
        </div>

        <h5 className="text-center fw-bold mb-1">Sign in to account</h5>
        <p className="text-center text-muted mb-4" style={{ fontSize: 13 }}>
          Enter your username & password to login
        </p>

        {error && (
          <div className="alert alert-danger text-center py-2">
            {error}
          </div>
        )}

        <form onSubmit={authenticateUser}>
          {/* Username */}
          <div className="mb-3">
            <label className="form-label small fw-semibold">User Name</label>
            <input
              type="text"
              className="form-control"
              placeholder="User name"
              value={credentials.userName}
              onChange={handleChange("userName")}
              disabled={isSubmitting}
              style={{ borderRadius: 8, height: 44 }}
            />
          </div>

          {/* Password */}
          <div className="mb-3">
            <label className="form-label small fw-semibold">Password</label>

            <div className="input-group">
              <input
                type={showPassword ? "text" : "password"}
                className="form-control"
                placeholder="Password"
                value={credentials.password}
                onChange={handleChange("password")}
                disabled={isSubmitting}
                style={{ borderRadius: "8px 0 0 8px", height: 44 }}
              />

              <button
                type="button"
                className="btn btn-light border"
                onClick={() => setShowPassword((p) => !p)}
                tabIndex={-1}
                style={{
                  borderRadius: "0 8px 8px 0",
                  cursor: "pointer",
                }}
              >
                <i
                  className={`ph ${showPassword ? "ph-eye" : "ph-eye-slash"}`}
                  style={{ fontSize: 18 }}
                />
              </button>
            </div>
          </div>

          {/* Remember + Forgot */}
          <div className="d-flex justify-content-between align-items-center mb-4">
            <div className="form-check">
              <input
                type="checkbox"
                className="form-check-input"
                checked={credentials.remoteUrl === "1"}
                onChange={(e) =>
                  setCredentials({
                    ...credentials,
                    remoteUrl: e.target.checked ? "1" : "0",
                  })
                }
              />
              <label className="form-check-label small">
                Remember Password
              </label>
            </div>

            <span
              className="small fw-semibold"
              style={{ cursor: "pointer" }}
              onClick={() => navigate("/forgot-password")}
            >
              Forgot Password
            </span>

          </div>

          {/* Submit */}
          <button
            type="submit"
            disabled={isSubmitting}
            className="btn w-100 text-white fw-semibold btn-primary"
            style={{
              height: 44,
              borderRadius: 8,
            }}
          >
            {isSubmitting ? "Signing In..." : "Sign In"}
          </button>
        </form>

        {/* Footer */}
        <div className="text-center mt-4 small">
          Don&apos;t have account?{" "}
          <span
            className="fw-semibold"
            style={{ cursor: "pointer" }}
            onClick={() => navigate("/create-account")}
          >
            Create Account
          </span>

        </div>
      </div>
    </div>
  );

};

export default Login;
